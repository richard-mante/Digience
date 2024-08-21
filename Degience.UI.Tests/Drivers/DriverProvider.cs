using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace Degience.UI.Tests.Drivers
{
    public class DriverProvider
    {
        private AndroidDriver _driver;
        public AppiumOptions GetOptions()
        {
            var capabilities = new AppiumOptions
            {
                PlatformName = "Android",
                DeviceName = "emulator-5554",
                AutomationName = AutomationName.AndroidUIAutomator2,
            };

            capabilities.AddAdditionalAppiumOption(MobileCapabilityType.NoReset, "true");
            capabilities.AddAdditionalAppiumOption(AndroidMobileCapabilityType.AppPackage, "com.companyname.digience");
            capabilities.AddAdditionalAppiumOption(AndroidMobileCapabilityType.AppActivity, "com.companyname.digience.MainActivity");

            return capabilities;
        }

        public AndroidDriver GetDriver()
        {
            if (_driver != null)
                return _driver;

            _driver = new AndroidDriver(new Uri("http://localhost:4723"), GetOptions(), TimeSpan.FromSeconds(120));

            return _driver;
        }
    }
}
