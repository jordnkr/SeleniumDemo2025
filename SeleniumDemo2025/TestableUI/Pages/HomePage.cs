using OpenQA.Selenium;
using SeleniumDemo2025.Shared;
using SeleniumDemo2025.Shared.Enums;

namespace SeleniumDemo2025.TestableUI.Pages
{
    public class HomePage : TestableUiBasePage
    {
        #region elements

        private static readonly By WelcomeHeader = By.XPath("//h1[text()='Welcome to My Website']");
        private static readonly By AboutLink = By.LinkText("About");

        #endregion

        public HomePage(IWebDriver driver) : base(driver)
        {
            Driver.WaitForElement(WelcomeHeader);
        }

        public HomePage(IWebDriver driver, TestEnvironment testEnvironment) : base(driver)
        {
            switch (testEnvironment)
            {
                case TestEnvironment.PROD:
                    Driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
                    break;
                default:
                    throw new Exception("error getting environment");
            }
            Driver.WaitForElement(WelcomeHeader);
        }

        public AboutPage ClickAboutLink()
        {
            Driver.WaitForElement(AboutLink).Click();
            return new AboutPage(Driver);
        }
    }
}