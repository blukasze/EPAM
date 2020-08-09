using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace UBS_Test_Automation.Framework.Setup
{
    public static class WebDriverExtensions
    {

        public static IWebElement FindElement(this IWebDriver driver, By by, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.Until(drv => drv.ExecuteJavaScript<string>("return document.readyState").Equals("complete"));
            return wait.Until(drv => drv.FindElement(by));
        }
    }
}
