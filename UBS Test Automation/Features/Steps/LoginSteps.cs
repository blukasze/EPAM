using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace UBS_Test_Automation.Features.Steps
{
    [Binding]
    class LoginSteps
    {

        [Given(@"I am on the main page")]
        public void GivenIAmOnTheMainPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I click on the login button")]
        public void GivenIClickOnTheLoginButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I type in incorrect credentials")]
        public void WhenITypeInIncorrectCredentials()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see the incorrect login or password message")]
        public void ThenISeeTheIncorrectLoginOrPasswordMessage()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
