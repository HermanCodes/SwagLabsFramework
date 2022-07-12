namespace SwagLabsFramework.Pages.Locators
{
    using OpenQA.Selenium;

    internal abstract class YourCartPageLocators
    {
        protected static By CheckoutButtonLocator => By.Id("checkout");

        protected static By ContinueShoppingButtonLocator => By.Id("continue-shopping");

        protected static By InventoryItemLocator => By.ClassName("inventory_item_name");

        protected static By RemoveButtonLocator(string item) => By.Id($"remove-sauce-labs-{item}");
    }
}
