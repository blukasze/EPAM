using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UBS_Test_Automation.Framework.Setup
{
    public static class WebElementExtensions
    {
        public static void Click(this IWebElement element, TimeSpan timeout)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element)
            {
                Timeout = timeout
            };
            wait.IgnoreExceptionTypes(typeof(ElementNotInteractableException));
            wait.Until(el =>
            {
                el.Click();
                return true;
            });
        }
    }
}
