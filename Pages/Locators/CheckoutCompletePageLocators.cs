namespace SwagLabsFramework.Pages.Locators;

using OpenQA.Selenium;

internal abstract class CheckoutCompletePageLocators
{
    protected static By OrderCompleteMessageLocator => By.ClassName("complete-header");
}