using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;
using UBS_Test_Automation.Framework.Setup;
using UBS_Test_Automation.Pages;

namespace UBS_Test_Automation.Features.Steps
{
    [Binding]
    class LoginSteps
    {
        public Config Config { get; set; }
        public MainPage MainPage { get; set; }
        public LoginPage LoginPage { get; set; }
        public PrivacySettingsPage PrivacySettingsPage { get; set; }

        public LoginSteps(ConfigReader configReader, MainPage mainPage, LoginPage loginPage, PrivacySettingsPage privacySettingsPage)
        {
            Config = configReader.Config;
            MainPage = mainPage;
            LoginPage = loginPage;
            PrivacySettingsPage = privacySettingsPage;
        }

        [Given(@"I am on the main page")]
        public void GivenIAmOnTheMainPage()
        {
            MainPage.GoToUrl();
            PrivacySettingsPage.ClickAgreeToAllButton();
        }

        [Given(@"I click on the login button")]
        public void GivenIClickOnTheLoginButton()
        {
            MainPage.ClickLoginButton();
            MainPage.ClickUSCLientAccountLogin();
        }

        [When(@"I type in incorrect credentials")]
        public void WhenITypeInIncorrectCredentials()
        {
            LoginPage.SetUsername(Config.Users.InvalidUser.username);
            LoginPage.SetPassword(Config.Users.InvalidUser.password);
        }

        [When(@"I click on the submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
            LoginPage.ClickSubmitButton();
        }


        [Then(@"I see the incorrect login or password message")]
        public void ThenISeeTheIncorrectLoginOrPasswordMessage()
        {
            LoginPage.AssertThatIncorrectCredemtialsMessageExists();
        }

    }
}
