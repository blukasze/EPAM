using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UBS_Test_Automation.Framework.Setup;

namespace UBS_Test_Automation.Features
{
    [Binding]
    public sealed class WebDriverHooks
    {
        private IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = DriverFactory.BuildDriver(DriverFactory.DriverType.Chrome);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
