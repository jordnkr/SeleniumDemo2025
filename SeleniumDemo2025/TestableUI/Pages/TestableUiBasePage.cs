using OpenQA.Selenium;
using SeleniumDemo2025.Shared;

namespace SeleniumDemo2025.TestableUI.Pages
{
    public abstract class TestableUiBasePage : BasePage
    {
        #region elements

        //private static readonly By Logo = By.XPath("");

        #endregion

        protected TestableUiBasePage(IWebDriver driver) : base(driver)
        { }

    }
}