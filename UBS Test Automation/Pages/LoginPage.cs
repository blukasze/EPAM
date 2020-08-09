using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using OpenQA.Selenium;
using UBS_Test_Automation.Features;
using UBS_Test_Automation.Framework.Setup;

namespace UBS_Test_Automation.Pages
{
    class LoginPage : BasePage
    {
        public LoginPage(SeleniumContext seleniumContext, ConfigReader configReader)
            : base("https://onlineservices.ubs.com/", seleniumContext, configReader)
        {

        }

        private IWebElement SubmitButton => Driver.FindElement(By.Id("submit"), WaitForElementExists);
        private IWebElement UsernameInput => Driver.FindElement(By.Id("username"), WaitForElementExists);
        private IWebElement PasswordInput => Driver.FindElement(By.Id("password"), WaitForElementExists);
        private IWebElement IncorrectCredemtialsMessage => 
            Driver.FindElement(By.XPath("//div[text() = 'The credentials you entered did not match. Please try again.']"), WaitForElementExists);

        public void ClickSubmitButton()
        {
            SubmitButton.Click();
        }

        public void SetUsername(string username)
        {
            UsernameInput.Clear();
            UsernameInput.SendKeys(username);
        }

        public void SetPassword(string password)
        {
            PasswordInput.Clear();
            PasswordInput.SendKeys(password);
        }

        public void AssertThatIncorrectCredemtialsMessageExists()
        {
            IncorrectCredemtialsMessage.Should().NotBeNull();
        }
    }
}
 