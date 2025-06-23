using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumDemo2025.Shared.Enums;

namespace SeleniumDemo2025.Shared
{
    [TestClass]
    public abstract class BaseTest
    {
        protected IWebDriver Driver;
        //private string DriverPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        Browser Browser = (Browser)Enum.Parse(typeof(Browser), "Chrome");
        protected TestEnvironment TestEnvironment = (TestEnvironment)Enum.Parse(typeof(TestEnvironment), "PROD");

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    protected BaseTest()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    { }

        [TestInitialize]
        public void BaseTestInitialize()
        {
            SetupDriver();
            //Cursor.Position = new Point(0, 0); // Move cursor to corner to avoid it interfering with tests.
        }

        [TestCleanup]
        public void BaseTestCleanup()
        {
            // TODO: Add screenshot taker later
            Driver.Quit();
        }

        /// <summary>
        /// Setup the IWebDriver object
        /// </summary>
        public void SetupDriver()
        {
            switch (Browser)
            {
                case Browser.Chrome:
                    var chromeOptions = new ChromeOptions();
                    //var service = ChromeDriverService.CreateDefaultService(DriverPath);
                    chromeOptions.AddArgument("--start-maximized");

                    // these 2 lines are needed for Lighthouse to use the existing browser window (otherwise opens it's own). Can comment these out if Lighthouse isn't going to be used.
                    chromeOptions.AddArgument("--remote-debugging-address=0.0.0.0");
                    chromeOptions.AddArgument($"--remote-debugging-port=4444");

                    Driver = new ChromeDriver(chromeOptions);
                    break;
                default:
                    throw new Exception("Unsupported browser value in App.config");
            }
        }
    }
}