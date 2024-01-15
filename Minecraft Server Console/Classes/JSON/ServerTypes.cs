using Newtonsoft.Json;

namespace Minecraft_Server_Console.Classes.JSON
{
    public class ServerTypesRoot
    {
        [JsonProperty("status")]
        public required string status { get; set; }

        [JsonProperty("response")]
        public required ServerTypesResponse response { get; set; }
    }

    public class ServerTypesResponse
    {
        [JsonProperty("bedrock")]
        public required List<string> bedrock { get; set; }

        [JsonProperty("modded")]
        public required List<string> modded { get; set; }

        [JsonProperty("proxies")]
        public required List<string> proxies { get; set; }

        [JsonProperty("servers")]
        public required List<string> servers { get; set; }

        [JsonProperty("vanilla")]
        public required List<string> vanilla { get; set; }
    }
}
