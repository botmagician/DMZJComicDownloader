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

namespace DMZJComicDownloader
{
    public partial class MainForm : Form
    {
        GlobalConfig globalConfig;
        DownloadTask comicTask;
        Task downloadTask;
        bool isDownloading=false;
        public MainForm()
        {
            globalConfig = GlobalConfig.LoadGlobalSettings();
            comicTask = new DownloadTask(globalConfig);
            InitializeComponent();
            saveTextBox.Text = globalConfig.defaultSaveFolder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (IWebDriver driver=new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("https://manhua.dmzj.com/qnlhsjy");
                IWebElement loginTip = driver.FindElement(By.CssSelector("div.login_tip.out"))
;               loginTip.Click();
                string js= "var x=document.querySelectorAll(\"div.cartoon_online_border ul li a\");Array.from(x).forEach(function(t){t.setAttribute(\"target\",\"_blank\");});";
                IJavaScriptExecutor jsex = (IJavaScriptExecutor)driver;
                string title = (string)jsex.ExecuteScript(js);
                IReadOnlyList<IWebElement> eles = driver.FindElements(By.CssSelector("div.cartoon_online_border ul li a"));
                foreach(IWebElement el in eles)
                {
                    el.Click();
                    Thread.Sleep(2000);
                }
            }
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
            downloadTask = Task.Run(dealTask);
            isDownloading = true;
        }
        private void dealTask()
        {

        }
    }
}
