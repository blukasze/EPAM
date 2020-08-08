using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using UBS_Test_Automation.Features;

namespace UBS_Test_Automation.Pages
{
    class MainPage : BasePage
    {
        public MainPage(SeleniumContext seleniumContext) : base("https://www.ubs.com/", seleniumContext)
        {
        }
    }
}
