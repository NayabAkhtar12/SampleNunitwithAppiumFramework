using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace NunitAppiumProj.Pages
{
    public class Page1 : Base
    {
        //  public AppiumDriver<AndroidElement> Driver { get; }

        public Page1(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver), "Driver cannot be null"); // Ensure driver is not null

            //  this.driver = driver;
        }


        public void Surah1()
        {
            try
            {
                AlFatiha?.Click();
            }
            catch (Exception e)
            {
                HandleException(e, "AlFatiha");
            }
            try
            {
                Driver?.Navigate().Back();
            }
            catch (Exception e)
            {
                HandleException(e, "Upon Back Navigation");
            }

        }

        public void Surah2M()
        {
            try
            {
                Surah2?.Click();
            }
            catch (Exception e)
            {
                HandleException(e, "Surah2");
            }
            try
            {
                Driver?.Navigate().Back();
            }
            catch (Exception e)
            {
                HandleException(e, "Upon Back Navigation");
            }
        }
        IWebElement? AlFatiha => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5\" and @text=\"Surat Al-Fatiha\"]");
        IWebElement? Surah2 => Driver?.FindElementByXPath("//adroid.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5\" and @text=\"Surat Aal-E-Imran\"]");

    }
}
