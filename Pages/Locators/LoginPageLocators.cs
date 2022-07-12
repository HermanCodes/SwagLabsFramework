namespace SwagLabsFramework.Pages.Locators;

using OpenQA.Selenium;

internal abstract class LoginPageLocators
{
    protected static By UsernameFieldLocator => By.Id("user-name");
    protected static By PasswordFieldLocator => By.Id("password");
    protected static By LoginButtonLocator => By.Id("login-button");
}