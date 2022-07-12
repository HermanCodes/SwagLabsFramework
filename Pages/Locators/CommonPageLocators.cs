namespace SwagLabsFramework.Pages.Locators;

using OpenQA.Selenium;

internal abstract class CommonPageLocators
{
    protected static By SidebarButtonLocator => By.Id("react-burger-menu-btn");

    protected static By LogoutButtonLocator => By.Id("logout_button");

    protected static By TwitterIconLocator => By.XPath("//li[@class='social_twitter']/a");
}