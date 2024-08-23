using Degience.UI.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Digience.UI.Tests.StepDefinitions
{
    [Binding]
    public class DegienceLogInStepDefinitions
    {

        private readonly MainPage _mainPage;

        public DegienceLogInStepDefinitions(MainPage mainPage)

        {
            _mainPage = mainPage;
        }


        [Given(@"John is on the login page")]
        public void GivenJohnIsOnTheLoginPage()
        {
            _mainPage.Title.Displayed.Should().BeTrue();
        }

        [When(@"John fills in the required details")]
        public void WhenJohnFillsInTheRequiredDetails()
        {
            _mainPage.LoginEmail.SendKeys("daniel.aikins@scynett.com");

            _mainPage.LoginPassword.SendKeys("Daniel");
        }

        [When(@"John clicks on the login button")]
        public void WhenJohnClicksOnTheLoginButton()
        {
            _mainPage.LoginButton.Click();
        }

        [Then(@"John should be logged in to the application")]
        public void ThenJohnShouldBeLoggedInToTheApplication()
        {
            // No action needed;
        }
    }
}
