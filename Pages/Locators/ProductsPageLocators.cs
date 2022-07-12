namespace SwagLabsFramework.Pages.Locators
{
    using OpenQA.Selenium;

    internal abstract class ProductsPageLocators
    {
        protected static By AddToCartLocator(string item) => By.Id($"add-to-cart-sauce-labs-{item}");
        protected static By CartButtonLocator => By.ClassName("shopping_cart_link");
    }
}
