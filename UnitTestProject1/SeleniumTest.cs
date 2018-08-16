using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using UnitTestProject1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTest
{
    public class SeleniumTest: Utilities 
    {
       
        [SetUp]
        public void Setup()
        {
            BrowserOptions();
        }

        [Test]
        public void TestMethod1()
        {   
            driver.Url = "https://www.google.com/gmail/about/#";
            driver.FindElement(By.LinkText("CREATE AN ACCOUNT")).Click();
            Thread.Sleep(3000);
        }


        [Test]
        public void TestMethod2()
        {
            driver.Url = "https://qaweb.empwr.com/";
            Thread.Sleep(3000);
        }

        [TearDown]
        public void teardown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}

