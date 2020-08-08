using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UBS_Test_Automation.Features.Steps
{
    [Binding]
    class YourLifeGoalsSteps
    {

        public YourLifeGoalsSteps()
        {

        }

        [Given(@"I am on the Your Life Goals page")]
        public void GivenIAmOnTheYourLifeGoalsPage()
        {

        }

        [When(@"I press the Get In Touch button")]
        public void WhenIPressTheGetInTouchButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I am presented with a contact form")]
        public void ThenIAmPresentedWithAContactForm()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
