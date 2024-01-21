namespace Minecraft_Server_Console
{
    public class ServerEventArgs : EventArgs
    {
        public DateTime StartTime { get; }
        public string PlayerName { get; }
        public string Reason { get; }

        public ServerEventArgs()
        {

        }

        public ServerEventArgs(DateTime startTime)
        {
            StartTime = startTime;
        }

        public ServerEventArgs(string playerName)
        {
            PlayerName = playerName;
        }

        public ServerEventArgs(string playerName, string reason)
        {
            PlayerName = playerName;
            Reason = reason;
        }
    }
}
