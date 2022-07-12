namespace SwagLabsFramework.Pages.Executors;

using Locators;
using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using SwagLabsFramework.Utility;

internal class CheckoutOverviewPage : CheckoutOverviewPageLocators
{
    private readonly IBrowserInteractions browserInteractions;

    public CheckoutOverviewPage(IBrowserInteractions browserInteractions)
    {
        this.browserInteractions = browserInteractions;
    }

    private IWebElement FinishButton => this.browserInteractions.WaitAndReturnElement(FinishButtonLocator);

    public void ClickFinishButton() => this.FinishButton.ClickWithWait();
}