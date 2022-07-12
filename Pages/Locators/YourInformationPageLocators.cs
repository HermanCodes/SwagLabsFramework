namespace SwagLabsFramework.Pages.Locators
{
    using OpenQA.Selenium;

    internal abstract class YourInformationPageLocators
    {
        protected static By FirstNameFieldLocator => By.Id("first-name");
        protected static By LastNameFieldLocator => By.Id("last-name");
        protected static By PostCodeFieldLocator => By.Id("postal-code");
        protected static By ContinueButtonLocator => By.Id("continue");
    }
}
