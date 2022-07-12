namespace SwagLabsFramework.Pages.Executors;

using Locators;
using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using SwagLabsFramework.Utility;

internal class ProductsPage : ProductsPageLocators
{
    private readonly IBrowserInteractions browserInteractions;

    public ProductsPage(IBrowserInteractions browserInteractions)
    {
        this.browserInteractions = browserInteractions;
    }

    private IWebElement AddToCart(string item) => this.browserInteractions.WaitAndReturnElement(AddToCartLocator(item));
    private IWebElement CartButton => this.browserInteractions.WaitAndReturnElement(CartButtonLocator);

    public void ClickAddToCart(string item) => this.AddToCart(item).ClickWithWait();
    public void ClickCartButton() => this.CartButton.ClickWithWait();



}