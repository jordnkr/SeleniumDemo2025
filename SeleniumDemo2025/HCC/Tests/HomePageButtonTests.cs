using FluentAssertions;
using SeleniumDemo2025.HCC.Pages;
using SeleniumDemo2025.Shared;

namespace SeleniumDemo2025.HCC.Tests
{
    [TestClass]
    public class HomePageButtonTests : BaseTest
    {
        /// <summary>
        /// Verifies that the 'Cash to Close' button navigates to the correct page
        /// </summary>
        [TestMethod]
        public void CashToCloseButton()
        {
            HCCHomePage hccHomePage = new HCCHomePage(Driver, TestEnvironment);
            CashToClosePage cashToClosePage = hccHomePage.ClickCashToCloseButton();
            cashToClosePage.IsTotalCashToCloseTextDisplayed().Should().BeTrue();
            Assert.IsTrue(cashToClosePage.IsTotalCashToCloseTextDisplayed());
        }
    }
}