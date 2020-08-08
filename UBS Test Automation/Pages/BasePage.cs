using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace UBS_Test_Automation.Pages
{
    class BasePage
    {
        public readonly string url;
        protected IWebDriver Driver { get; set; }
        
        public BasePage(string url, IWebDriver driver)
        {
            this.url = url;
            Driver = driver;
        }

        
    }
}
