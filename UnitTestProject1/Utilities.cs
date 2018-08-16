using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class Utilities
    {
        public IWebDriver driver;

        public void BrowserOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("--incognito");
            driver = new ChromeDriver("C:/chromedriver_win32/", options);
        }
    }
}
