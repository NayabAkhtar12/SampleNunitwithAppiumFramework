using ARDrawandSketch.Core;
using ARDrawandSketch.Pages;
using AventStack.ExtentReports;

namespace ARDrawandSketch.TestClass
{
    /* Oops: pillars 
     * Abstraction   : AppiumDriver Interface, 
     * Inheritance   : from Base class getting the driver instance
     * Encpsulation  : Making the members private/ Protected 
     * Polymorphism  : Implicit wait, time in minutes, seconds, Hours, action class, assert class
     *
      */
    [TestFixture]
    public class TestClass : Base
    {
        private Page1? P1;

        [SetUp]
        public void Initialize()
        {
            try
            {
                if (driver != null)
                    P1 = new Page1(driver);
            }
            catch (Exception e)
            {
                HandleException1(e, "Failed to initialize Page1");
            }
        }

        //Test Method to Execute test using Locators for Surah 1 from Page Class
        [Test, Order(2)]
        public void TestCase1()
        {
            ExtentTest test = Extent.CreateTest("Beginners Sketch Report");

            try
            {
                if (P1 != null)

                {

                    //   P1?.LearnToDraw();
                    P1?.BeginnersSketch1();
                    P1?.BeginnersSketch2();
                    P1?.BeginnersSketch3();
                    P1?.BeginnersSketch4();
                    P1?.BeginnersSketch5();
                    P1?.BeginnersSketch6();
                    P1?.BeginnersSketch7();
                    P1?.BeginnersSketch8();
                    P1?.BeginnersSketch9();
                    P1?.BeginnersSketch10();
                }
            }
            catch (Exception e)
            {
                HandleException1(e, "Error in TestCase1");
            }
        }

        //Test Method to Execute test using Locators for Surah 1 from Page Class..This test case will be executed on priority bases

        //   [Test, Order(1)]
        //public void TestCase2()
        //{
        //    try
        //    {
        //        P1?.Surah2M();
        //    }
        //    catch (Exception e)
        //    {
        //        HandleException1(e, "Error in TestCase2");
        //    }
        //}
    }

}