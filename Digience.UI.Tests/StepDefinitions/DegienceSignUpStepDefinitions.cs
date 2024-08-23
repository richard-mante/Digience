using Degience.UI.Tests.Pages;
using Digience.UI.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Digience.UI.Tests.StepDefinitions
{
    [Binding]
    public class DegienceSignUpStepDefinitions
    {

        private readonly SignUpPage _signUpPage;

        public DegienceSignUpStepDefinitions(SignUpPage signUpPage)
        {
            _signUpPage = signUpPage;
        }

        [Given(@"John is on the sign up page")]
        public void GivenJohnIsOnTheSignUpPage()
        {
            _signUpPage.SignUpLink.Click();

            _signUpPage.SignUpTitle.Displayed.Should().BeTrue();
        }

        [When(@"John fills the required information")]
        public void WhenJohnFillsTheRequiredInformation()
        {
            _signUpPage.SignUpEmail.SendKeys("daniel.aikins@scynett.com");

            _signUpPage.SignUpPassword.SendKeys("Daniel");

            _signUpPage.RepeatPassword.SendKeys("Daniel");
        }

        [When(@"clicks the sign up button")]
        public void WhenClicksTheSignUpButton()
        {
            _signUpPage.SignUpButton.Click();
        }

        [Then(@"John returns to the log in page to Log in")]
        public void ThenJohnReturnsToTheLogInPageToLogIn()
        {
            // No action needed;
        }
    }
}
