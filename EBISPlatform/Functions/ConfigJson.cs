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
    }

    public class Config
    {
        [JsonProperty("mysqlConnection")]
        public string MySqlConnection { get; set; }
    }
}
