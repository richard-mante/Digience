using OpenQA.Selenium.Appium;
using Degience.UI.Tests.Drivers;
using OpenQA.Selenium;


namespace Degience.UI.Tests.Pages
{
    public class MainPage : BasePage
    {
        public MainPage(DriverProvider driverProvider) : base(driverProvider)
        {
        }


        #region Elements

        public IWebElement Title =>
            Driver.FindElement(MobileBy.XPath("//android.widget.TextView[@text=\"Login\"]"));

        public IWebElement LoginEmail =>
            Driver.FindElement(MobileBy.XPath("//android.widget.EditText[@text=\"email\"]"));

        public IWebElement LoginPassword =>
            Driver.FindElement(MobileBy.XPath("//android.widget.EditText[@text=\"password\"]"));

        public IWebElement LoginButton =>
            Driver.FindElement(MobileBy.XPath("//android.widget.Button[@text=\"Login\"]"));

        #endregion
    }
}