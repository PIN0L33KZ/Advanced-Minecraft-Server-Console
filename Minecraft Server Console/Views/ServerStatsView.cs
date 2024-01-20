using System.Diagnostics;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;

namespace Minecraft_Server_Console.Views
{
    public partial class ServerStatsView : UserControl
    {
        private readonly ServerConsoleView _serverConsoleView;
        private string _remoteIpAddress;

        public ServerStatsView(ServerConsoleView serverConsoleView)
        {
            InitializeComponent();

            _serverConsoleView = serverConsoleView;
        }

        private void ServerStatsView_Load(object sender, EventArgs e)
        {
            Task updateIps = Task.Run(new Action(UpdateIps));
            Task updatePing = Task.Run(new Action(UpdatePing));
            Task updateUptime = Task.Run(new Action(UpdateServerUptime));
            Task updateRamUsage = Task.Run(new Action(UpdateRam));
            Task updateCpuUsage = Task.Run(new Action(UpdateCpu));
        }

        private async void UpdateIps()
        {
            while(true)
            {
                _remoteIpAddress = GetRemoteIPAsync();

                _ = BeginInvoke(new Action(() =>
                {
                    LBL_LocalIP.Text = "Local-IP: " + GetLocalIP();
                    LBL_RemoteIP.Text = "Remote-IP: " + _remoteIpAddress;
                }));

                HideRemoteIPAddress();

                await Task.Delay(6000);
            }
        }

        private async void UpdatePing()
        {
            while(true)
            {
                Ping ping = new();
                PingReply reply = ping.Send("8.8.8.8");

                _ = BeginInvoke(new Action(() => { LBL_Ping.Text = $"Ping: {reply.RoundtripTime}/ms"; }));
                await Task.Delay(1000);
            }
        }

        private async void UpdateServerUptime()
        {
            while(true)
            {
                DateTime startTime = _serverConsoleView.ServerStart;

                if(startTime == new DateTime())
                {
                    _ = BeginInvoke(new Action(() => { LBL_ServerUptime.Text = "Uptime: not started yet."; }));

                    await Task.Delay(1000);
                    continue;
                }

                DateTime now = DateTime.Now;

                TimeSpan span = now - startTime;

                _ = BeginInvoke(new Action(() => { LBL_ServerUptime.Text = $"Uptime: {FormatTimeSpan(span)}"; }));

                await Task.Delay(1000);
            }
        }

        private static string FormatTimeSpan(TimeSpan timeSpan)
        {
            return $"{(int)timeSpan.TotalHours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";
        }

        private static IPAddress GetLocalIP()
        {
            string hostname = Dns.GetHostName();

            IPAddress[] localIps = Dns.GetHostAddresses(hostname);

            foreach(IPAddress ip in localIps)
            {
                if(ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }

            return new IPAddress(0x0000000f);
        }

        private static string GetRemoteIPAsync()
        {
            using WebClient webClient = new();
            try
            {
                return webClient.DownloadString(@"https://api64.ipify.org");
            }
            catch(Exception ex)
            {
                _ = MessageBox.Show("Unable to fetch remote ip. You may be offline?\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        private async void UpdateRam()
        {
            ManagementObjectSearcher wmiObject = new("select * from Win32_OperatingSystem");

            while(true)
            {
                var memoryValues = wmiObject.Get().Cast<ManagementObject>().Select(mo => new
                {
                    FreePhysicalMemory = double.Parse(mo["FreePhysicalMemory"].ToString()),
                    TotalVisibleMemorySize = double.Parse(mo["TotalVisibleMemorySize"].ToString())
                }).FirstOrDefault();

                if(memoryValues != null)
                {
                    double percent = (memoryValues.TotalVisibleMemorySize - memoryValues.FreePhysicalMemory) / memoryValues.TotalVisibleMemorySize * 100;

                    _ = BeginInvoke(new Action(() => { LBL_RamUsage.Text = "RAM usage: " + Math.Round(percent).ToString() + "%"; }));
                }

                await Task.Delay(1000);
            }
        }

        private async void UpdateCpu()
        {
            PerformanceCounter c = new("Processor", "% Processor Time", "_Total");

            while(true)
            {
                _ = BeginInvoke(new Action(() => { LBL_CpuUsage.Text = $"CPU usage: {Math.Round(c.NextValue())}%"; }));
                await Task.Delay(1000);
            }
        }

        private void HideRemoteIPAddress()
        {
            string hiddenRemoteIpAddress = "";

            foreach(char c in _remoteIpAddress)
            {
                if(c == '.')
                {
                    continue;
                }

                if(char.IsNumber(c))
                {
                    hiddenRemoteIpAddress += "X";
                }
                else
                {
                    hiddenRemoteIpAddress += c.ToString();
                }
            }

            _ = LBL_RemoteIP.BeginInvoke(new Action(() => { LBL_RemoteIP.Text = "Remote-IP: " + hiddenRemoteIpAddress; }));
        }

        private void LBL_LocalIP_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LBL_LocalIP.Text.Split(':')[1].Trim());
        }

        private void LBL_RemoteIP_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LBL_RemoteIP.Text.Split(":")[1].Trim());
        }

        private void LBL_RemoteIP_MouseEnter(object sender, EventArgs e)
        {
            LBL_RemoteIP.Text = "Remote-IP: " + _remoteIpAddress;
        }

        private void LBL_RemoteIP_MouseLeave(object sender, EventArgs e)
        {
            HideRemoteIPAddress();
        }
    }
}