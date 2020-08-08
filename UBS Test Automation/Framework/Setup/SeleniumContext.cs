using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using UBS_Test_Automation.Framework.Setup;

namespace UBS_Test_Automation.Features
{
    [Binding]
    public class SeleniumContext
    {
        public IWebDriver WebDriver { get; private set; }           
        public SeleniumContext()
        {
            this.WebDriver= SetupWebDriver();
        }

        private IWebDriver SetupWebDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-notifications");
            return new ChromeDriver(options);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            WebDriver.Quit();
        }
    }
}
