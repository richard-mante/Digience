using Degience.UI.Tests.Drivers;
using OpenQA.Selenium.Appium.Android;


namespace Degience.UI.Tests.Pages
{
    public class BasePage
    {
        protected readonly AndroidDriver Driver;

        public BasePage(DriverProvider driverProvider)
        {
            Driver = driverProvider.GetDriver();
        }
    }
}