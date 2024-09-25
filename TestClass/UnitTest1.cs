using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace TestProject3.TestClass
{
    [TestFixture]
    public class AndroidTests
    {
        private AppiumDriver<AndroidElement> driver;

        [SetUp]
        public void Setup()
        {
            try
            {
                AppiumOptions cap = new AppiumOptions();
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Vivo Y03");
                cap.AddAdditionalCapability(MobileCapabilityType.Udid, "ONOZSG4H8HSGW8HY");
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "14");
                cap.AddAdditionalCapability("appium:automationName", AutomationName.AndroidUIAutomator2);

                // This is the key part that will launch the app
                cap.AddAdditionalCapability("appPackage", "com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim");
                cap.AddAdditionalCapability("appActivity", "com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim.ui.activities.MainActivity");
                string Appiumuri = "http://127.0.0.1:4723/";
                string Appiumuri1 = "http://192.168.100.14:4723/";

                driver = new AndroidDriver<AndroidElement>(new Uri(Appiumuri), cap, TimeSpan.FromSeconds(180));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to initialize driver: {e.Message}");
                throw;
            }
        }

        [Test]
        public void TestAppLaunch()
        {
            IWebElement AlFatiha = driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5\" and @text=\"Surat Al-Fatiha\"]");
            AlFatiha.Click();
            Assert.IsNotNull(AlFatiha);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }

}