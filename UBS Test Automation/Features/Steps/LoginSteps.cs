using System;
using System.Collections.Generic;
using System.Text;
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
        public LoginSteps(ConfigReader configReader, MainPage mainPage)
        {
            Config = configReader.Config;
            MainPage = mainPage;
        }

        [Given(@"I am on the main page")]
        public void GivenIAmOnTheMainPage()
        {
            System.Console.Out.WriteLine(MainPage.url);
        }

        [Given(@"I click on the login button")]
        public void GivenIClickOnTheLoginButton()
        {
            
        }

        [When(@"I type in incorrect credentials")]
        public void WhenITypeInIncorrectCredentials()
        {
            var invalidUser = Config.Users.InvalidUser.username;
            System.Console.Out.WriteLine(invalidUser);
        }

        [Then(@"I see the incorrect login or password message")]
        public void ThenISeeTheIncorrectLoginOrPasswordMessage()
        {
            
        }

    }
}
