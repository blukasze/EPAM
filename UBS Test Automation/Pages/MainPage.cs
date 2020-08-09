using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using UBS_Test_Automation.Features;
using UBS_Test_Automation.Framework.Setup;

namespace UBS_Test_Automation.Pages
{
    class MainPage : BasePage
    {
        public MainPage(SeleniumContext seleniumContext, ConfigReader configReader)
            : base("https://www.ubs.com/", seleniumContext, configReader)
        {
        }

        private IWebElement LoginButton => 
            Driver.FindElement(By.XPath("//button[@id='headerLoginToggleButton']/span[text() = 'UBS logins']"), WaitForElementExists);

        private IWebElement USClientAccountLogin =>
            Driver.FindElement(By.XPath("//a[text() = 'US client account login']"), WaitForElementExists);

        private IWebElement NavBarElement =>
            Driver.FindElement(By.CssSelector("nav[aria-labelledby='headerNavTitle']"), WaitForElementExists);

        public void ClickLoginButton()
        {
            NavBarElement.Click();
            LoginButton.Click();
        }

        public void ClickUSCLientAccountLogin()
        {
            USClientAccountLogin.Click(WaitForElementToBeInteractable);
        }
    }
}
