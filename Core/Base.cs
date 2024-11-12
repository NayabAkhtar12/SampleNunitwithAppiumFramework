using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace ARDrawandSketch.Core
{
    [TestFixture]
    public class Base
    {
        protected AppiumDriver<AndroidElement>? driver;
        public static ExtentReports Extent;
        private static ExtentSparkReporter _reporter;

        public AppiumDriver<AndroidElement>? Driver
        {
            get
            {
                return driver;
            }
        }
        //   protected AppiumDriver<AndroidElement> Driver => driver; // Protected property to access driver
        static Base()
        {
            string reportPath = @"D:\Reports\ARDrawandSketchTestReport.html";
            _reporter = new ExtentSparkReporter(reportPath);
            Extent = new ExtentReports();
            Extent.AttachReporter(_reporter);
        }
        [SetUp]
        public void Setup()
        {
            try
            {
                AppiumOptions cap = new AppiumOptions();
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "C7");
                cap.AddAdditionalCapability(MobileCapabilityType.Udid, "e7c7d60c");
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "8");
                cap.AddAdditionalCapability("appium:automationName", AutomationName.AndroidUIAutomator2);

                // This is the key part that will launch the app
                cap.AddAdditionalCapability("appPackage", "");
                cap.AddAdditionalCapability("appActivity", "");
                string Appiumuri = "http://127.0.0.1:4723/";
                //     string Appiumuri1 = "http://192.168.100.14:4723/";

                driver = new AndroidDriver<AndroidElement>(new Uri(Appiumuri), cap, TimeSpan.FromSeconds(180));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            }
            catch (Exception e)
            {
                HandleException1(e, "Failed to initialize driver in Setup");
            }
        }
        protected void HandleException1(Exception ex, string context)
        {
            // Log the exception message and stack trace
            Console.WriteLine($"Exception occurred: {context}");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine($"StackTrace: {ex.StackTrace}");

            // Optionally, you can fail the test if this is called from a test method
            Assert.Fail($"Test failed due to exception: {ex.Message}");
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
        }
    }

}
