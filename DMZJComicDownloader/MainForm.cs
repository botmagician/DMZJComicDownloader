using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Net;
using System.IO;
using OpenQA.Selenium.Interactions;

namespace DMZJComicDownloader
{
    public partial class MainForm : Form
    {
        GlobalConfig globalConfig;
        DownloadTask comicTask;
        Task downloadTask;
        bool isDownloading=false;
        CancellationTokenSource cancel;
        public MainForm()
        {
            globalConfig = GlobalConfig.LoadGlobalSettings();
            comicTask = new DownloadTask(globalConfig);
            InitializeComponent();
            saveTextBox.Text = globalConfig.defaultSaveFolder;
        }

        private void findFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            comicTask.saveFolderUri = folderBrowserDialog1.SelectedPath;
            globalConfig.defaultSaveFolder = comicTask.saveFolderUri;
            saveTextBox.Text = comicTask.saveFolderUri;
        }

        private void saveTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {
            comicTask.comicUrl = urlTextBox.Text;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            comicTask.comicName = nameTextBox.Text;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (isDownloading)
            {
                MessageBox.Show("正在运行，请勿重复开启任务");
            }
            cancel = new CancellationTokenSource();
            downloadTask = Task.Factory.StartNew(dealTask,cancel.Token,TaskCreationOptions.LongRunning,TaskScheduler.Default);
            isDownloading = true;
            //dealTask();
        }
        private void dealTask()
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                string savePath = comicTask.saveFolderUri + @"\" + comicTask.comicName;
                if (!Directory.Exists(savePath))
                {
                    Directory.CreateDirectory(savePath);
                }
                savePath += "\\";
                driver.Navigate().GoToUrl(comicTask.comicUrl);
                IWebElement loginTip = driver.FindElement(By.CssSelector("div.login_tip.out"));
                loginTip.Click();
                string js = "var x=document.querySelectorAll(\"div.cartoon_online_border ul li a\");Array.from(x).forEach(function(t){t.setAttribute(\"target\",\"_blank\");});";
                IJavaScriptExecutor jsex = (IJavaScriptExecutor)driver;
                string title = (string)jsex.ExecuteScript(js);
                string deleteAd = "var elem = document.getElementsByClassName('ad_bottom_code')[0]; " + "elem.parentNode.removeChild(elem);  ";
                jsex.ExecuteScript(deleteAd);
                IReadOnlyList<IWebElement> comicParts = driver.FindElements(By.CssSelector("div.cartoon_online_border ul li a"));
                int comicPartsCount = comicParts.Count;
                for(int i = 0; i < comicPartsCount; i++)
                {
                    string savePathCap = savePath + "\\" + comicParts[i].Text;
                    if (!Directory.Exists(savePathCap))
                    {
                        Directory.CreateDirectory(savePathCap);
                    }
                    savePathCap += "\\";
                    string originalWindow = driver.CurrentWindowHandle;
                    comicParts[i].Click();
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000000000));
                    wait.Until(wd => wd.WindowHandles.Count == 2);
                    foreach (string window in driver.WindowHandles)
                    {
                        
                        if (originalWindow != window)
                        {
                            driver.SwitchTo().Window(window);
                            break;
                        }
                    }
                    IWebElement pic = wait.Until(wd => wd.FindElement(By.Name("page_1")));
                    int pageCount = 1;
                    if (i < comicPartsCount - 1)
                    {
                        while (driver.FindElement(By.ClassName("mask_panel")).GetAttribute("style").Contains("none")&& !driver.Url.Contains("jump"))
                        {
                            if (cancel.Token.IsCancellationRequested)
                            {
                                return;
                            }
                            pic = wait.Until(wd => wd.FindElement(By.Name("page_"+pageCount.ToString())));
                            DownloadFile(pic.GetAttribute("src"), savePathCap + pageCount.ToString() + ".jpg");
                            pageCount++;
                            driver.FindElement(By.ClassName("img_land_next")).Click();
                        }
                    }
                    else
                    {
                        while (!driver.Url.Contains("jump"))
                        {
                            if (cancel.Token.IsCancellationRequested)
                            {
                                return;
                            }
                            pic = wait.Until(wd => wd.FindElement(By.Name("page_" + pageCount.ToString())));
                            DownloadFile(pic.GetAttribute("src"), savePathCap + pageCount.ToString() + ".jpg");
                            pageCount++;
                            driver.FindElement(By.ClassName("img_land_next")).Click();
                        }
                    }
                    
                   // IWebElement nextPage = driver.FindElement(By.ClassName("img_land_next"));
                    
                    //DownloadFile(pic.GetAttribute("src"), "ss.jpg");
                    //关闭标签页或窗口
                    driver.Close();

                    //切回到之前的标签页或窗口
                    driver.SwitchTo().Window(originalWindow);
                }
            }
            isDownloading = false;
        }
        public void DownloadFile(string url,string filename)
        {
            try
            {
                HttpWebRequest req = WebRequest.CreateHttp(url);
                req.Method = "GET";
                req.Referer = "https://manhua.dmzj.com/";
                req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/93.0.4577.63 Safari/537.36";
                var response = req.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                Stream fileStream = new FileStream(filename, FileMode.OpenOrCreate);
                byte[] bArr = new byte[1024];
                int size;
                do
                {
                    size = stream.Read(bArr, 0, (int)bArr.Length);
                    fileStream.Write(bArr, 0, size);
                } while (size > 0);
                fileStream.Close();
                stream.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (isDownloading)
            {
                cancel.Cancel();
                isDownloading = false;
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
