using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace UBS_Test_Automation.Framework.Setup
{
    public static class DriverFactory
    {
        public enum DriverType
        {
            Chrome,
            Firefox
        }

        public static IWebDriver BuildDriver(DriverType type)
        {
            IWebDriver driver;
            switch (type)
            {
                case DriverType.Chrome:
                    driver = new ChromeDriver();
                    break;
                case DriverType.Firefox:
                    driver = new FirefoxDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            return driver;
        }
        

    }
}
