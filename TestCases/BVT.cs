using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

using NUnit.Framework;
using AFPWebTest.TestFramework;
using PageObjectFactory = Selenium.Tools.PageFactory;

namespace AFPWebTest.TestCases
{
    [TestFixture]
    public class BVT : AFPWebTestBase
    {
        [Test]
        [TestCase("camel", "123456")]
        public void LoginTest(string username, string passwd)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://172.16.1.122:8080");

            PageObjectFactory.UIMapFilePath = @"E:\adSage.Concert\src_test\AFPWebTest\TestFramework\UIMaps";
            LoginPage loginPage = PageObjectFactory.InitPage<LoginPage>(driver);
            loginPage.SelectLanguage(LanguageType.English);

            loginPage = loginPage.Refresh(driver);
            loginPage.Login(username, passwd);

            this.AddTestCleanup("Close Browser",
                () => { driver.Close(); });
        }
    }
}
