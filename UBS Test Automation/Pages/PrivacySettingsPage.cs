using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using UBS_Test_Automation.Features;
using UBS_Test_Automation.Framework.Setup;

namespace UBS_Test_Automation.Pages
{
    class PrivacySettingsPage : BasePage
    {
        public PrivacySettingsPage(SeleniumContext seleniumContext, ConfigReader configReader)
            : base("https://www.ubs.com/", seleniumContext, configReader)
        {
        }

        private IWebElement AgreeToAllButton => Driver.FindElement(By.XPath("//span[text() = 'Agree to all']"), WaitForElementExists);

        private IWebElement PrivacySettingsIFrame =>
            Driver.FindElement(By.CssSelector("iframe[src*='privacy-settings.cookieLightbox']"), WaitForElementExists);
       

        public void ClickAgreeToAllButton()
        {
            Driver.SwitchTo().Frame(PrivacySettingsIFrame);
            AgreeToAllButton.Click();
        }
    }
}
