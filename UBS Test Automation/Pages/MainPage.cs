using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace UBS_Test_Automation.Pages
{
    class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base("https://www.ubs.com/", driver)
        {
        }
    }
}
