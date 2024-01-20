using System.Diagnostics;

namespace Minecraft_Server_Console.Views
{
    public partial class ServerConsoleView : UserControl
    {
        public static event EventHandler<ServerEventArgs> ServerStarted;
        private Process? _serverProcess;

        public ServerConsoleView()
        {
            InitializeComponent();

            TBX_Command.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionHandler;
        }

        private async void BTN_StartServer_Click(object sender, EventArgs e)
        {
            TBX_ConsoleLog.Clear();

            if(!Directory.Exists(Properties.Application.Default.ApplicationPath))
            {
                TBX_ConsoleLog.AppendText($"Error: Your selected directory doesn't exists anymore.\nPlease re-create it or re-run the program to set everythin up properly.\nSelected directory: {Properties.Application.Default.ApplicationPath}");
                return;
            }

            try
            {
                string[] jarFiles = Directory.GetFiles(Properties.Application.Default.ApplicationPath, "*.jar");
                string[] jarFile = jarFiles[0].Split('\\');

                BTN_StartServer.Enabled = false;
                ProgressIndicator.Show();

                if(GetServerProcess().Length > 0)
                {
                    Process[] serverProcess = GetServerProcess();
                    foreach(Process process in serverProcess)
                    {
                        process.Kill();
                        await process.WaitForExitAsync();
                    }
                }

                await Task.Run(() => { StartServerProcess(jarFile[^1]); });

                BTN_StartServer.Enabled = true;
                BTN_StopServer.Enabled = false;
                BTN_ReloadServer.Enabled = false;
                ProgressIndicator.Hide();
            }
            catch(Exception ex)
            {
                TBX_ConsoleLog.AppendText("Error: Unable to start your Minecraft Server\n" + ex.Message);
            }
        }

        private void StartServerProcess(string jarFile)
        {
            _serverProcess = new Process();
            _serverProcess.StartInfo.FileName = "cmd.exe";
            _serverProcess.StartInfo.Arguments = $"/c cd \"{Properties.Application.Default.ApplicationPath}\" && java -Xmx1G -Xms1G -jar {jarFile} nogui";
            _serverProcess.StartInfo.UseShellExecute = false;
            _serverProcess.StartInfo.RedirectStandardOutput = true;
            _serverProcess.StartInfo.RedirectStandardInput = true;
            _serverProcess.StartInfo.RedirectStandardError = true;
            _serverProcess.StartInfo.CreateNoWindow = true;
            _serverProcess.OutputDataReceived += Process_OutputDataReceived;
            _serverProcess.ErrorDataReceived += Process_ErrorDataReceived;

            _ = _serverProcess.Start();

            _serverProcess.BeginOutputReadLine();
            _serverProcess.BeginErrorReadLine();

            _serverProcess.WaitForExit();
            _serverProcess.Close();
        }

        protected static void OnServerStarted(DateTime startTime)
        {
            ServerStarted?.Invoke(null, new ServerEventArgs(startTime));
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if(string.IsNullOrEmpty(e.Data))
            {
                return;
            }

            #region Iterate through keywords
            _ = BeginInvoke(new Action(() =>
            {
                switch(e.Data)
                {
                    case var s when e.Data.Contains("You need to agree to the EULA"):
                        BTN_AgreeToEula.Show();
                        goto default;

                    case var s when e.Data.Contains("INFO]: Done ") && !e.Data.Contains('<') && !e.Data.Contains('>'):
                        BTN_StopServer.Enabled = true;
                        BTN_ReloadServer.Enabled = true;
                        PNL_SendCommandArea.Enabled = true;
                        ProgressIndicator.Hide();
                        OnServerStarted(DateTime.Now);
                        goto default;

                    case var s when e.Data.Contains("INFO]: CONSOLE: Reload complete.") && !e.Data.Contains('<') && !e.Data.Contains('>'):
                        BTN_StopServer.Enabled = true;
                        BTN_ReloadServer.Enabled = true;
                        PNL_SendCommandArea.Enabled = true;
                        ProgressIndicator.Hide();
                        goto default;

                    case var s when e.Data.Contains("INFO]: Stopping the server") && !e.Data.Contains('<') && !e.Data.Contains('>'):
                        BTN_StopServer.Enabled = false;
                        BTN_ReloadServer.Enabled = false;
                        PNL_SendCommandArea.Enabled = false;
                        ProgressIndicator.Show();
                        goto default;

                    #region Syntax highlighting
                    case var s when e.Data.Contains("warn", StringComparison.CurrentCultureIgnoreCase) || e.Data.Contains("warning", StringComparison.CurrentCultureIgnoreCase):
                        TBX_ConsoleLog.SelectionStart = TBX_ConsoleLog.TextLength;
                        TBX_ConsoleLog.SelectionLength = 0;
                        TBX_ConsoleLog.SelectionColor = Color.FromArgb(243, 156, 18);
                        TBX_ConsoleLog.AppendText(e.Data + Environment.NewLine);
                        TBX_ConsoleLog.SelectionColor = TBX_ConsoleLog.ForeColor;
                        TBX_ConsoleLog.ScrollToCaret();
                        break;

                    case var s when e.Data.Contains("fatal", StringComparison.CurrentCultureIgnoreCase) || e.Data.Contains("error", StringComparison.CurrentCultureIgnoreCase):
                        TBX_ConsoleLog.SelectionStart = TBX_ConsoleLog.TextLength;
                        TBX_ConsoleLog.SelectionLength = 0;
                        TBX_ConsoleLog.SelectionColor = Color.FromArgb(255, 82, 82);
                        TBX_ConsoleLog.AppendText(e.Data + Environment.NewLine);
                        TBX_ConsoleLog.SelectionColor = TBX_ConsoleLog.ForeColor;
                        TBX_ConsoleLog.ScrollToCaret();
                        break;

                    #endregion

                    default:
                        TBX_ConsoleLog.AppendText($"{e.Data}{Environment.NewLine}");
                        TBX_ConsoleLog.ScrollToCaret();
                        break;
                }
            }));
            #endregion
        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if(string.IsNullOrEmpty(e.Data))
            {
                return;
            }

            _ = TBX_ConsoleLog.BeginInvoke(new Action(() =>
            {
                TBX_ConsoleLog.AppendText($"{e.Data}{Environment.NewLine}");
                TBX_ConsoleLog.ScrollToCaret();
            }));
        }

        private void BTN_AgreeToEula_Click(object sender, EventArgs e)
        {
            try
            {
                string eulaText = File.ReadAllText(Properties.Application.Default.ApplicationPath + @"\eula.txt");
                eulaText = eulaText.Replace("eula=false", "eula=true");
                File.WriteAllText(Properties.Application.Default.ApplicationPath + @"\eula.txt", eulaText);
            }
            catch(Exception ex)
            {
                TBX_ConsoleLog.AppendText("Error: Can't automatically agree to eula.\n" + ex.Message);
            }

            BTN_AgreeToEula.Hide();
            BTN_StartServer.PerformClick();
        }

        private void BTN_StopServer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you wish to shutdown the server?", "Stop server", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                return;
            }

            ProgressIndicator.Show();
            BTN_StopServer.Enabled = false;
            BTN_ReloadServer.Enabled = false;
            _serverProcess.StandardInput.WriteLine("stop" + Environment.NewLine);
        }

        private void BTN_ReloadServer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you wish reload the server?", "Reload server", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                return;
            }

            ProgressIndicator.Show();
            PNL_SendCommandArea.Enabled = false;
            BTN_ReloadServer.Enabled = false;
            BTN_StopServer.Enabled = false;
            _serverProcess.StandardInput.WriteLine("reload confirm" + Environment.NewLine);
        }

        private void BTN_SendCommand_Click(object sender, EventArgs e)
        {
            if(TBX_Command.TextLength == 0)
            {
                return;
            }

            if(TBX_Command.Text[0] == '/')
            {
                TBX_Command.Text = TBX_Command.Text.Remove(0, 1);
            }

            if(TBX_Command.Text.Equals("stop", StringComparison.CurrentCultureIgnoreCase))
            {
                TBX_Command.Clear();
                BTN_StopServer.PerformClick();
                return;
            }

            if(TBX_Command.Text.Equals("reload", StringComparison.CurrentCultureIgnoreCase) || TBX_Command.Text.Equals("reload confirm", StringComparison.CurrentCultureIgnoreCase))
            {
                TBX_Command.Clear();
                BTN_ReloadServer.PerformClick();
                return;
            }

            TBX_ConsoleLog.AppendText("> " + TBX_Command.Text.Trim() + Environment.NewLine);
            TBX_ConsoleLog.ScrollToCaret();
            _serverProcess.StandardInput.WriteLine(TBX_Command.Text.Trim());
            TBX_Command.Clear();
        }

        private void TBX_Command_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter)
            {
                return;
            }

            BTN_SendCommand.PerformClick();
            e.SuppressKeyPress = true;
        }

        private async void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = (Exception)e.ExceptionObject;

            _serverProcess.StandardInput.WriteLine("stop");
            await _serverProcess.WaitForExitAsync();

            _ = MessageBox.Show("Unhandled Exception! Your Server was stopped gracefully.\n" + exception.Message, "Unhandled exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static Process[] GetServerProcess()
        {
            string processName = "java";

            Process[] processes = Process.GetProcessesByName(processName);

            return processes;
        }
    }

    public class ServerEventArgs : EventArgs
    {
        public DateTime StartTime { get; }

        public ServerEventArgs(DateTime startTime)
        {
            StartTime = startTime;
        }
    }
}