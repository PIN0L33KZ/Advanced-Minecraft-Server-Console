namespace Minecraft_Server_Console
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            if(args.Length > 0 && args[0] == "reset-settings")
            {
                Properties.Application.Default.Reset();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new FRM_Console());
        }
    }
}