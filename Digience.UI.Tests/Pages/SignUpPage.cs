using OpenQA.Selenium.Appium;
using Degience.UI.Tests.Drivers;
using OpenQA.Selenium;
using Degience.UI.Tests.Pages;

namespace Digience.UI.Tests.Pages
{
    public class SignUpPage : BasePage
    {
        public SignUpPage(DriverProvider driverProvider) : base(driverProvider)
        {
        }

        #region Elements

        public IWebElement SignUpLink =>
            Driver.FindElement(MobileBy.XPath("//android.widget.TextView[@text=\"Sign Up\"]"));

        public IWebElement SignUpTitle =>
            Driver.FindElement(MobileBy.AndroidUIAutomator("new UiSelector().text(\"Login\").instance(0)"));

        public IWebElement SignUpEmail =>
           Driver.FindElement(MobileBy.AndroidUIAutomator("new UiSelector().text(\"email\")"));

        public IWebElement SignUpPassword =>
           Driver.FindElement(MobileBy.AndroidUIAutomator("//android.widget.EditText[@text=\"password\"]"));

        public IWebElement RepeatPassword =>
           Driver.FindElement(MobileBy.AndroidUIAutomator("new UiSelector().text(\"repeat password\")"));

        public IWebElement SignUpButton =>
           Driver.FindElement(MobileBy.XPath("//android.widget.Button[@text=\"Login\"]"));

        #endregion
    }
}
