namespace SwagLabsFramework.Pages.Executors;

using Locators;
using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using Utility;

internal class CommonPage : CommonPageLocators
{
    private readonly IBrowserInteractions browserInteractions;

    public CommonPage(IBrowserInteractions browserInteractions)
    {
        this.browserInteractions = browserInteractions;
    }

    private IWebElement SidebarButton => this.browserInteractions.WaitAndReturnElement(SidebarButtonLocator);

    private IWebElement LogoutButton => this.browserInteractions.WaitAndReturnElement(LogoutButtonLocator);

    private IWebElement TwitterIcon => this.browserInteractions.WaitAndReturnElement(TwitterIconLocator);

    public string GetPageUrl() => this.browserInteractions.GetUrl();

    public void Logout()
    {
        this.SidebarButton.ClickWithWait();
        this.LogoutButton.ClickWithWait();
    }

    public string GetTwitterIconHrefAttribute() => this.TwitterIcon.GetHrefAttribute();
}