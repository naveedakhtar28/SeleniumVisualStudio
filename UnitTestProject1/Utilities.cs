using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class Utilities
    {
        public IWebDriver driver;
        protected ExtentReports _extent;
        protected ExtentTest _test;
        

        [OneTimeSetUp]
        public void Setup()
        {
            var ExecutionBrowser = System.Environment.GetEnvironmentVariable("Browser");
               // var ExecutionBrowser = "Chrome";
            switch (ExecutionBrowser)
            {
                case "Chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("start-maximized");
                    options.AddArguments("--incognito");
                    driver = new ChromeDriver("C:/chromedriver_win32/", options);
                    break;

                case "Firefox":
                    System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", "C:/geckodriver/geckodriver.exe");
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(3);
                    break;

                    //case Browser.IE:
                    //    driver = new InternetExplorerDriver(@"C:\repos\Testing\Tests");
                    //    break;
            }
            
            //_test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
           
            //var dir = "C:/Reports/";
            //var fileName = this.GetType().ToString() + ".html";
            //var fileDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Reports\");
            //var htmlReporter = new ExtentHtmlReporter(fileDirectory+ this.GetType().ToString() + ".html");

            //_extent = new ExtentReports();
            //htmlReporter.LoadConfig(System.AppDomain.CurrentDomain.BaseDirectory + "extent-config.xml");
            //_extent.AttachReporter(htmlReporter);
            //KlovReporter klovReporter = new KlovReporter();
            //klovReporter.InitMongoDbConnection("localhost", 27017);
            //klovReporter.ProjectName = "Selenium Extent Report";
            //klovReporter.ReportName = "Build " + DateTime.Now.ToString();
            //klovReporter.KlovUrl = "http://localhost";
            //_extent.AttachReporter(klovReporter);
        }

        [OneTimeTearDown]
        public void AfterTest()
        {
            driver.Quit();
            //var status = TestContext.CurrentContext.Result.Outcome.Status;
            //var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
            //        ? ""
            //        : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            //Status logstatus;

            //switch (status)
            //{
            //    case TestStatus.Failed:
            //        logstatus = Status.Fail;
            //        break;
            //    case TestStatus.Inconclusive:
            //        logstatus = Status.Warning;
            //        break;
            //    case TestStatus.Skipped:
            //        logstatus = Status.Skip;
            //        break;
            //    default:
            //        logstatus = Status.Pass;
            //        break;
            //}

            //_test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            //_extent.Flush();
        }

        [OneTimeTearDown]
        protected void TearDown()
        {
            //_extent.Flush();
        }

        //[SetUp]
        //public IWebDriver GetWebDriverForBrowser()
        //{
        //    IWebDriver driver = null;

        //    switch (ExecutionBrowser)
        //    {
        //        case "Chrome":
        //            ChromeOptions options = new ChromeOptions();
        //            options.AddArguments("start-maximized");
        //            options.AddArguments("--incognito");
        //            driver = new ChromeDriver("C:/chromedriver_win32/", options);
        //            break;

        //        case "Firefox":
        //            System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", "C:/geckodriver-v0.21.0-win64/geckodriver.exe");
        //            driver = new FirefoxDriver();
        //            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(3);
        //            driver.Manage().Window.Maximize();
        //            break;

        //            //case Browser.IE:
        //            //    driver = new InternetExplorerDriver(@"C:\repos\Testing\Tests");
        //            //    break;
        //    }
        //    if (driver != null)
        //    {
        //        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(3);
        //    }
        //    //_test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
        //    return driver;
        //}
        ////ChromeOptions options = new ChromeOptions();
        ////options.AddArguments("start-maximized");
        ////options.AddArguments("--incognito");
        ////driver = new ChromeDriver("C:/chromedriver_win32/", options);

        //}
    }
}

