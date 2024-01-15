using Newtonsoft.Json;

namespace Minecraft_Server_Console.Classes.JSON
{
    public class ServerVersionsResponse
    {
        [JsonProperty("version")]
        public required string version { get; set; }
    }

    public class ServerVersionsRoot
    {
        [JsonProperty("status")]
        public required string status { get; set; }

        [JsonProperty("response")]
        public required List<ServerVersionsResponse> response { get; set; }
    }
}
