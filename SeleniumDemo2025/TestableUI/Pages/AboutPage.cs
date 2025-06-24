using OpenQA.Selenium;
using SeleniumDemo2025.Shared;

namespace SeleniumDemo2025.TestableUI.Pages
{
    public class AboutPage : TestableUiBasePage
    {
        #region elements

        private static readonly By AboutUsHeader = By.XPath("//h1[text()='About Us']");
        private static readonly By OurStoryHeader = By.XPath("//h2[text()='Our Story']");

        #endregion

        public AboutPage(IWebDriver driver) : base(driver)
        {
            Driver.WaitForElement(AboutUsHeader);
        }

        public bool IsOurStoryHeaderDisplayed()
        {
            return Driver.IsElementDisplayed(OurStoryHeader);
        }
    }
}