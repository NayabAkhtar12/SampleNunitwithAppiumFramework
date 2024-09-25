using NunitAppiumProj.Core;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace NunitAppiumProj.Pages
{
    public class ReusableMethods : Base
    {

        public ReusableMethods(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }


        protected void HandleException(Exception ex, string context)
        {
            // Log the exception message and stack trace
            Console.WriteLine($"Exception occurred: {context}");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine($"StackTrace: {ex.StackTrace}");

            // Optionally, you can fail the test if this is called from a test method
            Assert.Fail($"Test failed due to exception: {ex.Message}");
        }

    }
}
