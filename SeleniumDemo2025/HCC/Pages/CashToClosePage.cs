using OpenQA.Selenium;
using SeleniumDemo2025.Shared;

namespace SeleniumDemo2025.HCC.Pages
{
    public class CashToClosePage : HCCBasePage
    {
        #region elements

        private static readonly By CashToCloseFinalNumberText = By.Id("cashToClose");

        #endregion

        public CashToClosePage(IWebDriver driver) : base(driver)
        {
            Driver.WaitForElement(CashToCloseFinalNumberText);
        }

        public bool IsTotalCashToCloseTextDisplayed()
        {
            return Driver.IsElementDisplayed(CashToCloseFinalNumberText);
        }
    }
}