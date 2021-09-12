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
    public class ComicInfo
    {
        public string name;
        public string alias;
        public string originalName;
        public List<string> authors;
        public string region;
        public string status;
        public string popularity;
        public List<string> themes;
        public string classification;
        public string cartoonDesc;
        public List<string> chapters;
        public ComicInfo()
        {
            name = "";
            alias = "";
            originalName = "";
            authors = new List<string>();
            region = "";
            status = "";
            popularity = "";
            themes = new List<string>();
            classification = "";
            cartoonDesc = "";
            chapters = new List<string>();
        }
        public ComicInfo(string Name,string Alias,string OriginalName, List<string> Authors,string Region,string Status ,string Popularity, List<string> Themes,string Classification,string CartoonDesc, List<string> Chapters)
        {
            name = Name;
            alias = Alias;
            originalName = OriginalName;
            authors = Authors;
            region = Region;
            status = Status;
            popularity = Popularity;
            themes = Themes;
            classification = Classification;
            cartoonDesc = CartoonDesc;
            chapters = Chapters;
        }
        public ComicInfo(string Name, List<string> Authors, string Region, string Status, List<string> Themes, string Classification,List<string> Chapters)
        {
            name = Name;
            alias = "";
            originalName = "";
            authors = Authors;
            region = Region;
            status = Status;
            popularity = "";
            themes = Themes;
            classification = Classification;
            cartoonDesc = "";
            chapters = Chapters;
        }
        public ComicInfo(string Name, List<string> Authors ,string Region,string Status, List<string> Themes,string Classification,string CartoonDesc, List<string> Chapters)
        {
            name = Name;
            alias = "";
            originalName = "";
            authors = Authors;
            region = Region;
            status = Status;
            popularity = "";
            themes = Themes;
            classification = Classification;
            cartoonDesc = CartoonDesc;
            chapters = Chapters;
        }
        public static ComicInfo GetComicInfo(string comicUrl)
        {
            ComicInfo info = new ComicInfo();
            using(IWebDriver driver=new FirefoxDriver())
            {
                driver.Navigate().GoToUrl(comicUrl);
                IWebElement loginTip = driver.FindElement(By.CssSelector("div.login_tip.out"));
                loginTip.Click();
                string js = "var x=document.querySelectorAll(\"div.cartoon_online_border ul li a\");Array.from(x).forEach(function(t){t.setAttribute(\"target\",\"_blank\");});";
                IJavaScriptExecutor jsex = (IJavaScriptExecutor)driver;
                string title = (string)jsex.ExecuteScript(js);
                string deleteAd = "var elem = document.getElementsByClassName('ad_bottom_code')[0]; " + "elem.parentNode.removeChild(elem);  ";
                jsex.ExecuteScript(deleteAd);
                IReadOnlyList<IWebElement> comicParts = driver.FindElements(By.CssSelector("div.cartoon_online_border ul li a"));
                for(int i=0;i<comicParts.Count;i++)
                {
                    info.chapters.Add(comicParts[i].Text);
                }
                info.name = driver.FindElement(By.XPath("/html/body/div[5]/div[2]/div[1]/div[1]/div[2]/span[1]/a/h1")).Text;
                info.alias = driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[1]/td")).Text;
                info.originalName= driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[2]/td")).Text;
                foreach(IWebElement ele in driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[3]/td")).FindElements(By.TagName("a"))){
                    info.authors.Add(ele.Text);
                }
                info.region = driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[4]/td/a")).Text;
                info.status = driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[5]/td/a")).Text;
                info.popularity = driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[6]/td")).Text;
                foreach (IWebElement ele in driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[7]/td")).FindElements(By.TagName("a")))
                {
                    info.themes.Add(ele.Text);
                }
                info.classification = driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[8]/td/a")).Text;
                try
                {
                    info.cartoonDesc = driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/div/a")).Text;
                }catch(Exception ex)
                {
                    info.cartoonDesc = "";
                }
            }
            return info;
        }
        public static ComicInfo GetComicInfo(string comicUrl,IWebDriver driver)
        {
            ComicInfo info = new ComicInfo();
                IReadOnlyList<IWebElement> comicParts = driver.FindElements(By.CssSelector("div.cartoon_online_border ul li a"));
                for (int i = 0; i < comicParts.Count; i++)
                {
                    info.chapters.Add(comicParts[i].Text);
                }
                info.name = driver.FindElement(By.XPath("/html/body/div[5]/div[2]/div[1]/div[1]/div[2]/span[1]/a/h1")).Text;
                info.alias = driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[1]/td")).Text;
                info.originalName = driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[2]/td")).Text;
                foreach (IWebElement ele in driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[3]/td")).FindElements(By.TagName("a")))
                {
                    info.authors.Add(ele.Text);
                }
                info.region = driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[4]/td/a")).Text;
                info.status = driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[5]/td/a")).Text;
                info.popularity = driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[6]/td")).Text;
                foreach (IWebElement ele in driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[7]/td")).FindElements(By.TagName("a")))
                {
                    info.themes.Add(ele.Text);
                }
                info.classification = driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/table/tbody/tr[8]/td/a")).Text;
                try
                {
                    info.cartoonDesc = driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div[1]/div[2]/div/div[4]/div/a")).Text;
                }
                catch (Exception ex)
                {
                    info.cartoonDesc = "";
                }
            return info;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.name);
            sb.AppendLine(this.alias);
            sb.AppendLine(this.originalName);
            foreach(string s in this.authors)
            {
                sb.Append(s + " ");
            }
            sb.AppendLine();
            sb.AppendLine(this.region);
            sb.AppendLine(this.status);
            sb.AppendLine(this.popularity);
            foreach (string s in this.themes)
            {
                sb.Append(s + " ");
            }
            sb.AppendLine();
            sb.AppendLine(this.classification);
            sb.AppendLine(this.cartoonDesc);
            foreach (string s in this.chapters)
            {
                sb.Append(s + " ");
            }
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
