using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EBISPlatform.Functions
{
    public class ConfigJson
    {
        public static Config jsonConfig;

        public async Task ConfigureJsonAsync()
        {
            var json = string.Empty;

            using (var fs = File.OpenRead(@"..\..\Local\jsconfig.json"))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
                json = await sr.ReadToEndAsync().ConfigureAwait(false);

            jsonConfig = JsonConvert.DeserializeObject<Config>(json);
        }
        public async Task EditJsonAsync(string username, string password)
        {
            jsonConfig.Username = username;
            jsonConfig.Password = password;

            var json = JsonConvert.SerializeObject(jsonConfig);
            File.WriteAllText(@"..\..\Local\jsconfig.json", json);
        }
    }

    public class Config
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("mysqlConnection")]
        public string MySqlConnection { get; set; }
    }
}
