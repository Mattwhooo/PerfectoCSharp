using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using TestRemote;


namespace ClassLibrary2
{
    [TestFixture]
    public class UnitTest1
    {

        RemoteWebDriverExtended driver;

        [SetUp]
        public void TestSetUp()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            String user = HttpUtility.UrlEncode("api@orasi.com");
            String password = HttpUtility.UrlEncode("Orasi01!");
            String host = HttpUtility.UrlEncode("mobiletesting.orasi.com");
            int timeout = 60;
            Console.WriteLine("RunStarted");
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("app-package", "com.sec.android.app.popupcalculator");
            capabilities.SetCapability("app-activity", "com.sec.android.app.popupcalculator.Calculator");
            Uri urend = new Uri("https://" + user + ':' + password + '@' + host + "/nexperience/wd/hub");
            ICommandExecutor commandExecutor = new HttpAuthenticatedCommandExecutor(urend);
            driver = new RemoteWebDriverExtended(commandExecutor, capabilities);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(timeout));
            driver.Context = "NATIVE_APP";

        }

        [Test]
        public void TestMethod1()
        {

            String commandStartApp = "mobile:application:open";
            var parameters = new Dictionary<string, string>();
            parameters.Add("name", "Calculator");
            Object result = driver.ExecuteScript(commandStartApp, parameters);
        }

        [Test]
        public void TestMethod2()
        {

            String commandStartApp = "mobile:application:open";
            var parameters = new Dictionary<string, string>();
            parameters.Add("name", "Calculator");
            Object result = driver.ExecuteScript(commandStartApp, parameters);
        }

        [Test]
        public void TestMethod3()
        {

            String commandStartApp = "mobile:application:open";
            var parameters = new Dictionary<string, string>();
            parameters.Add("name", "Calculator");
            Object result = driver.ExecuteScript(commandStartApp, parameters);
        }

        [TearDown]
        public void FixtureTearDown()
        {
            // closes every window associated with this driver
            driver.Quit();
        }
    }
}