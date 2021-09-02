using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMZJComicDownloader
{
    class DownloadTask
    {
        public string saveFolderUri;
        public string comicName;
        public string comicUrl;
        public DownloadTask()
        {
            
        }
        public DownloadTask(string url,string name,string folder)
        {
            comicUrl = url;
            comicName = name;
            saveFolderUri = folder;
        }
        public DownloadTask(GlobalConfig config)
        {
            saveFolderUri = config.defaultSaveFolder;
            comicName = "";
            comicUrl = "";
        }
    }
}
