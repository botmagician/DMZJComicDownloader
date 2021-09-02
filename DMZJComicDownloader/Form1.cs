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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                    Thread.Sleep(2000);
                    el.Click();
                    
                }
            }
        }
    }
}
