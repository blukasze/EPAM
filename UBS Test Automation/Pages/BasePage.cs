using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using UBS_Test_Automation.Features;

namespace UBS_Test_Automation.Pages
{
    class BasePage
    {
        public readonly string url;
        protected IWebDriver Driver { get; set; }
        
        public BasePage(string url, SeleniumContext seleniumContext)
        {
            this.url = url;
            Driver = seleniumContext.WebDriver;
        }
    }
}
