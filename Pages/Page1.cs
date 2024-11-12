using ARDrawandSketch.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace ARDrawandSketch.Pages
{
    public class Page1 : Base
    {
        //  public AppiumDriver<AndroidElement> Driver { get; }
        Reusablemethods Reusablemethods;

        public Page1(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver), "Driver cannot be null"); // Ensure driver is not null
            Reusablemethods = new Reusablemethods(driver);

        }

        //Method to perform action on BeginnersSketch using Locators
        public void BeginnersSketch11()
        {


        }
        public void BeginnersSketch1()
        {
            // Reusablemethods.ScrollToElementByText("Colorful");

            Reusablemethods.ClickwithAd(seeall, "seeall");
            Reusablemethods.ClickwithAd(BegSketch1, "Sketch 1");
            Reusablemethods.ClickwithAd(startDrawing, "startDrawing");
            Reusablemethods.ClickwithAd(GuideContinue, "GuideContinue");
            Reusablemethods.ElementClick(Flash, "Flash");
            Reusablemethods.ElementClick(Record, "RecordVideo");
            Thread.Sleep(4000);
            Reusablemethods.ElementClick(Capture, "Capture");
            Reusablemethods.ClickwithAd(Done, "Done");
            Reusablemethods.ClickwithAd(GotoHome, "GotoHome");

        }

        public void BeginnersSketch2()
        {
            // Reusablemethods.ScrollToElementByText("Colorful");

            Reusablemethods.ClickwithAd(seeall, "seeall");
            Reusablemethods.ClickwithAd(BegSketch2, "Sketch 2");
            Reusablemethods.ClickwithAd(startDrawing, "startDrawing");
            Reusablemethods.ClickwithAd(GuideContinue, "GuideContinue");
            Reusablemethods.ElementClick(Flash, "Flash");
            Reusablemethods.ElementClick(Record, "RecordVideo");
            Thread.Sleep(4000);
            Reusablemethods.ElementClick(Capture, "Capture");
            Reusablemethods.ClickwithAd(Done, "Done");
            Reusablemethods.ClickwithAd(GotoHome, "GotoHome");


        }

        public void BeginnersSketch3()
        {
            // Reusablemethods.ScrollToElementByText("Colorful");

            Reusablemethods.ClickwithAd(seeall, "seeall");
            Reusablemethods.ClickwithAd(BegSketch3, "Sketch 3");
            Reusablemethods.ClickwithAd(startDrawing, "startDrawing");
            Reusablemethods.ClickwithAd(GuideContinue, "GuideContinue");
            Reusablemethods.ElementClick(Flash, "Flash");
            Reusablemethods.ElementClick(Record, "RecordVideo");
            Thread.Sleep(4000);
            Reusablemethods.ElementClick(Capture, "Capture");
            Reusablemethods.ClickwithAd(Done, "Done");
            Reusablemethods.ClickwithAd(GotoHome, "GotoHome");
        }

        public void BeginnersSketch4()
        {
            //Reusablemethods.ScrollToElementByText("Colorful");

            Reusablemethods.ClickwithAd(seeall, "seeall");
            Reusablemethods.ClickwithAd(BegSketch4, "Sketch 4");
            Reusablemethods.ClickwithAd(startDrawing, "startDrawing");
            Reusablemethods.ClickwithAd(GuideContinue, "GuideContinue");
            Reusablemethods.ElementClick(Flash, "Flash");
            Reusablemethods.ElementClick(Record, "RecordVideo");
            Thread.Sleep(4000);
            Reusablemethods.ElementClick(Capture, "Capture");
            Reusablemethods.ClickwithAd(Done, "Done");
            Reusablemethods.ClickwithAd(GotoHome, "GotoHome");
        }

        public void BeginnersSketch5()
        {
            //Reusablemethods.ScrollToElementByText("Colorful");

            Reusablemethods.ClickwithAd(seeall, "seeall");
            Reusablemethods.ClickwithAd(BegSketch5, "Sketch 5");
            Reusablemethods.ClickwithAd(startDrawing, "startDrawing");
            Reusablemethods.ClickwithAd(GuideContinue, "GuideContinue");
            Reusablemethods.ElementClick(Flash, "Flash");
            Reusablemethods.ElementClick(Record, "RecordVideo");
            Thread.Sleep(4000);
            Reusablemethods.ElementClick(Capture, "Capture");
            Reusablemethods.ClickwithAd(Done, "Done");
            Reusablemethods.ClickwithAd(GotoHome, "GotoHome");
        }
        public void BeginnersSketch6()
        {
            //Reusablemethods.ScrollToElementByText("Colorful");

            Reusablemethods.ClickwithAd(seeall, "seeall");
            Reusablemethods.ClickwithAd(BegSketch6, "Sketch 6");
            Reusablemethods.ClickwithAd(startDrawing, "startDrawing");
            Reusablemethods.ClickwithAd(GuideContinue, "GuideContinue");
            Reusablemethods.ElementClick(Flash, "Flash");
            Reusablemethods.ElementClick(Record, "RecordVideo");
            Thread.Sleep(4000);
            Reusablemethods.ElementClick(Capture, "Capture");
            Reusablemethods.ClickwithAd(Done, "Done");
            Reusablemethods.ClickwithAd(GotoHome, "GotoHome");
        }
        public void BeginnersSketch7()
        {
            //Reusablemethods.ScrollToElementByText("Colorful");

            Reusablemethods.ClickwithAd(seeall, "seeall");
            Reusablemethods.ClickwithAd(BegSketch7, "Sketch 7");
            Reusablemethods.ClickwithAd(startDrawing, "startDrawing");
            Reusablemethods.ClickwithAd(GuideContinue, "GuideContinue");
            Reusablemethods.ElementClick(Flash, "Flash");
            Reusablemethods.ElementClick(Record, "RecordVideo");
            Thread.Sleep(4000);
            Reusablemethods.ElementClick(Capture, "Capture");
            Reusablemethods.ClickwithAd(Done, "Done");
            Reusablemethods.ClickwithAd(GotoHome, "GotoHome");
        }
        public void BeginnersSketch8()
        {
            //Reusablemethods.ScrollToElementByText("Colorful");

            Reusablemethods.ClickwithAd(seeall, "seeall");
            Reusablemethods.ClickwithAd(BegSketch8, "Sketch 8");
            Reusablemethods.ClickwithAd(startDrawing, "startDrawing");
            Reusablemethods.ClickwithAd(GuideContinue, "GuideContinue");
            Reusablemethods.ElementClick(Flash, "Flash");
            Reusablemethods.ElementClick(Record, "RecordVideo");
            Thread.Sleep(4000);
            Reusablemethods.ElementClick(Capture, "Capture");
            Reusablemethods.ClickwithAd(Done, "Done");
            Reusablemethods.ClickwithAd(GotoHome, "GotoHome");
        }
        public void BeginnersSketch9()
        {
            //Reusablemethods.ScrollToElementByText("Colorful");

            Reusablemethods.ClickwithAd(seeall, "seeall");
            Reusablemethods.ClickwithAd(BegSketch9, "Sketch 9");
            Reusablemethods.ClickwithAd(startDrawing, "startDrawing");
            Reusablemethods.ClickwithAd(GuideContinue, "GuideContinue");
            Reusablemethods.ElementClick(Flash, "Flash");
            Reusablemethods.ElementClick(Record, "RecordVideo");
            Thread.Sleep(4000);
            Reusablemethods.ElementClick(Capture, "Capture");
            Reusablemethods.ClickwithAd(Done, "Done");
            Reusablemethods.ClickwithAd(GotoHome, "GotoHome");
        }
        public void BeginnersSketch10()
        {
            //Reusablemethods.ScrollToElementByText("Colorful");

            Reusablemethods.ClickwithAd(seeall, "seeall");
            Reusablemethods.ClickwithAd(BegSketch10, "Sketch 10");
            Reusablemethods.ClickwithAd(startDrawing, "startDrawing");
            Reusablemethods.ClickwithAd(GuideContinue, "GuideContinue");
            Reusablemethods.ElementClick(Flash, "Flash");
            Reusablemethods.ElementClick(Record, "RecordVideo");
            Thread.Sleep(4000);
            Reusablemethods.ElementClick(Capture, "Capture");
            Reusablemethods.ClickwithAd(Done, "Done");
            Reusablemethods.ClickwithAd(GotoHome, "GotoHome");
        }

        //Method to perform action on Surah 1 using Locators
        public void LearnToDraw()
        {
            if (BegSketch1 == null)
            {
                Console.WriteLine("Error: BegSketch1 is null. Unable to perform sketch workflow.");
                return; // or throw an exception
            }

            PerformSketchWorkflow(BegSketch1);
            PerformSketchWorkflow(BegSketch2);
            PerformSketchWorkflow(BegSketch3);
            PerformSketchWorkflow(BegSketch4);
            PerformSketchWorkflow(BegSketch5);
            PerformSketchWorkflow(BegSketch6);
            PerformSketchWorkflow(BegSketch7);
            PerformSketchWorkflow(BegSketch8);
            PerformSketchWorkflow(BegSketch9);
            PerformSketchWorkflow(BegSketch10);

        }

        public void PerformSketchWorkflow(IWebElement? sketchElement)
        {
            if (sketchElement == null)
            {
                Assert.Fail("BegSketch1 is null. Unable to proceed with the test.");
            }
            Reusablemethods.ClickwithAd(seeall, "seeall");
            Reusablemethods.ClickwithAd(sketchElement, "BegSketch1");
            Reusablemethods.ClickwithAd(startDrawing, "startDrawing");
            Reusablemethods.ClickwithAd(GuideContinue, "GuideContinue");
            Reusablemethods.ElementClick(Flash, "Flash");
            Reusablemethods.ElementClick(Record, "RecordVideo");
            Thread.Sleep(4000);
            Reusablemethods.ElementClick(Capture, "Capture");
            Reusablemethods.ClickwithAd(Done, "Done");
            Reusablemethods.ClickwithAd(GotoHome, "GotoHome");
        }

        //Element Locator for Surah Location
        IWebElement? seeall => Reusablemethods.FindElement(By.XPath("(//android.widget.TextView[@resource-id=\"com.seedalyara.ardraw.sketch:id/seelTv\"])[1]"), "seeall");
        IWebElement? BegSketch1 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.seedalyara.ardraw.sketch:id/imageView\"])[1]"), "BegSketch1");
        IWebElement? BegSketch2 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.seedalyara.ardraw.sketch:id/imageView\"])[2]"), "BegSketch2");
        IWebElement? BegSketch3 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.seedalyara.ardraw.sketch:id/imageView\"])[3]"), "BegSketch3");
        IWebElement? BegSketch4 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.seedalyara.ardraw.sketch:id/imageView\"])[4]"), "BegSketch4");
        IWebElement? BegSketch5 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.seedalyara.ardraw.sketch:id/imageView\"])[5]"), "BegSketch5");
        IWebElement? BegSketch6 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.seedalyara.ardraw.sketch:id/imageView\"])[6]"), "BegSketch6");
        IWebElement? BegSketch7 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.seedalyara.ardraw.sketch:id/imageView\"])[7]"), "BegSketch7");
        IWebElement? BegSketch8 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.seedalyara.ardraw.sketch:id/imageView\"])[8]"), "BegSketch8");
        IWebElement? BegSketch9 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.seedalyara.ardraw.sketch:id/imageView\"])[9]"), "BegSketch9");
        IWebElement? BegSketch10 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.seedalyara.ardraw.sketch:id/imageView\"])[10]"), "BegSketch10");
        IWebElement? startDrawing => Reusablemethods.FindElement(By.Id("com.seedalyara.ardraw.sketch:id/startDrawing"), "startDrawing");
        IWebElement? GuideContinue => Reusablemethods.FindElement(By.Id("com.seedalyara.ardraw.sketch:id/contiBtn"), "GuideContinue");
        IWebElement? Capture => Reusablemethods.FindElement(By.Id("com.seedalyara.ardraw.sketch:id/capture_btn"), "Capture");
        IWebElement? Done => Reusablemethods.FindElement(By.Id("com.seedalyara.ardraw.sketch:id/finishBtn"), "Done");
        IWebElement? GotoHome => Reusablemethods.FindElement(By.Id("com.seedalyara.ardraw.sketch:id/homeBtn"), "GotoHome");
        IWebElement? Flash => Reusablemethods.FindElement(By.Id("com.seedalyara.ardraw.sketch:id/rel_flash"), "Sample");
        IWebElement? Record => Reusablemethods.FindElement(By.Id("com.seedalyara.ardraw.sketch:id/rec_btn"), "Sample");

        //  IWebElement? startDrawing => Reusablemethods.FindElement(By.Id(""), "Sample");
        IWebElement? Beg2 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[9]"), "AirHorn9");


    }
}
