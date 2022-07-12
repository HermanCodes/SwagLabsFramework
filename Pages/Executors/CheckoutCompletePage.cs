namespace SwagLabsFramework.Pages.Executors;

using Locators;
using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;

internal class CheckoutCompletePage : CheckoutCompletePageLocators
{
    private readonly IBrowserInteractions browserInteractions;

    public CheckoutCompletePage(IBrowserInteractions browserInteractions)
    {
        this.browserInteractions = browserInteractions;
    }

    private IWebElement OrderCompleteMessage => this.browserInteractions.WaitAndReturnElement(OrderCompleteMessageLocator);

    public string GetPageUrl() => this.browserInteractions.GetUrl();

    public bool CheckMessageIsDisplayed() => this.OrderCompleteMessage.Displayed;
}