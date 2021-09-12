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
        public ComicInfo comicInfo;
        public string comicUrl;
        public DownloadTask()
        {
            
        }
        public DownloadTask(string url,ComicInfo info,string folder)
        {
            comicInfo = info;
            comicUrl = url;
            saveFolderUri = folder;
        }
        public DownloadTask(GlobalConfig config)
        {
            saveFolderUri = config.defaultSaveFolder;
            comicInfo = null;
            comicUrl = "";
        }
    }
}
