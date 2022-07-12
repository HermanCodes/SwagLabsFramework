namespace SwagLabsFramework.Pages.Executors;

using Locators;
using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using SwagLabsFramework.Utility;

internal class YourCartPage : YourCartPageLocators
{
    private readonly IBrowserInteractions browserInteractions;

    public YourCartPage(IBrowserInteractions browserInteractions)
    {
        this.browserInteractions = browserInteractions;
    }

    private IWebElement CheckoutButton => this.browserInteractions.WaitAndReturnElement(CheckoutButtonLocator);

    private IWebElement RemoveButton(string item) => this.browserInteractions.WaitAndReturnElement(RemoveButtonLocator(item));

    private IWebElement ContinueShoppingButton => this.browserInteractions.WaitAndReturnElement(ContinueShoppingButtonLocator);

    private IEnumerable<IWebElement> InventoryItems => this.browserInteractions.WaitAndReturnElements(InventoryItemLocator);

    public void ClickCheckoutButton() => this.CheckoutButton.ClickWithWait();

    public void ClickRemoveButton(string item) => this.RemoveButton(item).ClickWithWait();

    public void ClickContinueShoppingButton() => this.ContinueShoppingButton.SendKeys("Click");

    public bool BasketIsEmpty() => this.InventoryItems.Count().Equals(1);
}