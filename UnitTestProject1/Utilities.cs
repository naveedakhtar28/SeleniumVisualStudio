﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

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
            var ExecutionEnvironment = System.Environment.GetEnvironmentVariable("Environment");

            switch (ExecutionBrowser)
            {
                case "Chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("start-maximized");
                    options.AddArguments("--incognito");
                    driver = new ChromeDriver("C:/chromedriver_win32/", options);
                    break;

                case "Firefox":
                    //System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", "geckodriver.exe");
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(3);
                    break;

                case "Internet Explorer":
                    driver = new InternetExplorerDriver("C:/IEDriverServer/");
                    break;
            }

            switch (ExecutionEnvironment)
            {
                case "Dev":
                    driver.Url = "https://www.cricbuzz.com/";
                    Thread.Sleep(10000);
                    break;

                case "QA":
                    driver.Url = "http://www.espncricinfo.com/";
                    Thread.Sleep(10000);
                    break;

                case "Prod":
                    driver.Url = "https://www.news18.com/cricketnext/?ref=topnav";
                    Thread.Sleep(10000);
                    break;
            }

            //var fileName = this.GetType().ToString() + ".html";
            //var fileDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Reports\");
            //var htmlReporter = new ExtentHtmlReporter(fileDirectory + this.GetType().ToString() + ".html");

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

        [SetUp]
        public void TestSetup()
        {
            //_test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void AfterTest()
        {
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
        public void OneTimeTeardown()
        {
            driver.Quit();
        }
        
    }
}

