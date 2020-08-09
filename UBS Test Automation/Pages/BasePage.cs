using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using UBS_Test_Automation.Features;
using UBS_Test_Automation.Framework.Setup;

namespace UBS_Test_Automation.Pages
{
    class BasePage
    {
        public readonly string url;
        protected IWebDriver Driver { get; set; }
        public TimeSpan WaitForElementExists { get; set; }
        public TimeSpan WaitForElementToBeInteractable { get; set; }

        public BasePage(string url, SeleniumContext seleniumContext, ConfigReader configReader)
        {
            this.url = url;
            Driver = seleniumContext.WebDriver;
            WaitForElementExists = configReader.Config.Timeouts.WaitForElementExists;
            WaitForElementToBeInteractable = configReader.Config.Timeouts.WaitForElementToBeInteractable;
        }

        public void GoToUrl()
        {
            Driver.Navigate().GoToUrl(url);
        }
    }
}
