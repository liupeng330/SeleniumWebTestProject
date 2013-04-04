using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Tools;

namespace AFPWebTest.TestFramework
{
    public class LoginPage : PageBase
    {
        [NeedRefresh]
        public IWebElement UserNameInput { get; set; }
        [NeedRefresh]
        public IWebElement PassWordInput { get; set; }
        public IWebElement SelectLanguageLinkBar { get; set; }
        public IWebElement EnglisghLanguageLink { get; set; }

        public LoginPage(IWebDriver driver)
        {
            this.webDriver = driver;
        }

        public void Login(string userName, string passwd)
        {
            this.UserNameInput.SendKeys(userName);
            this.PassWordInput.SendKeys(passwd);
            this.UserNameInput.Submit();
        }

        public void SelectLanguage(LanguageType type)
        {
            Actions actions = new Actions(this.webDriver);
            actions.MoveToElement(SelectLanguageLinkBar);
            actions.MoveToElement(EnglisghLanguageLink);
            actions.Click();
            actions.Perform();
        }
    }
}
