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
       
        [Test]
        public void TestMethod1()
        {   
            driver.Url = "https://www.google.com/gmail/about/#";
            Thread.Sleep(3000);
        }


        [Test]
        public void TestMethod2()
        {
            driver.Url = "https://qaweb.empwr.com/";
            Thread.Sleep(3000);
        }

        [Test]
        public void TestMethod3()
        {
            driver.Url = "https://www.news18.com/";
            driver.FindElement(By.LinkText("CREATE AN ACCOUNT")).Click();
            Thread.Sleep(3000);
        }

    }
}

