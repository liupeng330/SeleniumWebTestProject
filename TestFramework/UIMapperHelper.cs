using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Selenium.Tools;
using OpenQA.Selenium;

namespace AFPWebTest.TestFramework
{
    public static class UIMapperHelper
    {
        public static Tpage Refresh<Tpage>(this Tpage page, IWebDriver driver) where Tpage : class
        {
            return PageFactory.RefreshPage<Tpage>(driver);
        }

        public static Tpage Init<Tpage>(this Tpage page, IWebDriver driver) where Tpage : class
        {
            return PageFactory.InitPage<Tpage>(driver);
        }
    }
}
