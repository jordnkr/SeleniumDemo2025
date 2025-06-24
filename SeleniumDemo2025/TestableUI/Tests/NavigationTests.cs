using FluentAssertions;
using SeleniumDemo2025.TestableUI.Pages;
using SeleniumDemo2025.Shared;

namespace SeleniumDemo2025.TestableUI.Tests
{
  [TestClass]
  public class NavigationTests : BaseTest
  {
    /// <summary>
    /// Verifies that a user can navigate to the About page
    /// </summary>
    [TestMethod]
    public void NavigateToAboutUsPageTest()
    {
      HomePage homePage = new HomePage(Driver, TestEnvironment);
      AboutPage aboutPage = homePage.ClickAboutLink();
      Assert.IsTrue(aboutPage.IsOurStoryHeaderDisplayed());
    }
  }
}