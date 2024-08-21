using Degience.UI.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Degience.UI.Tests.StepDefinitions
{
    [Binding]
    public class DegienceSignUpStepDefinitions
    {

        private readonly MainPage _mainPage;

        public DegienceSignUpStepDefinitions(MainPage mainPage)
        {
            _mainPage = mainPage;
        }

        [Given(@"John is on the sign up page")]
        public void GivenJohnIsOnTheSignUpPage()
        {
            _mainPage.SignUpLink.Click();

            _mainPage.Title.Displayed.Should().BeTrue();
        }

        [When(@"John fills the required information")]
        public void WhenJohnFillsTheRequiredInformation()
        {
            _mainPage.SignUpEmail.SendKeys("daniel.aikins@scynett.com");

            _mainPage.SignUpPassword.SendKeys("Daniel");

            _mainPage.RepeatPassword.SendKeys("Daniel");
        }

        [When(@"clicks the sign up button")]
        public void WhenClicksTheSignUpButton()
        {
            _mainPage.SignUpButton.Click();
        }

        [Then(@"John returns to the log in page to Log in")]
        public void ThenJohnReturnsToTheLogInPageToLogIn()
        {
            // No action needed;
        }
    }
}
