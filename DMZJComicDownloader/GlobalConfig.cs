using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace DMZJComicDownloader
{
    class GlobalConfig
    {
        public string defaultSaveFolder;
        private static readonly string ConfigFile = "configdmzj.txt";
        public static GlobalConfig LoadGlobalSettings()
        {
            try
            {
                string rawConfig = File.ReadAllText(ConfigFile);

                return JsonConvert.DeserializeObject<GlobalConfig>(rawConfig);
            }catch(FileNotFoundException ex)
            {
                return new GlobalConfig("");
            }
        }
        public GlobalConfig(string folder)
        {
            defaultSaveFolder = folder;
        }
        ~GlobalConfig()
        {
            File.WriteAllText(ConfigFile,JsonConvert.SerializeObject(this));
        }
    }
}
