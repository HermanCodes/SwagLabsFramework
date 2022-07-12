namespace SwagLabsFramework.Pages.Executors;

using Locators;
using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using Utility;

internal class LoginPage : LoginPageLocators
{
    private readonly IBrowserInteractions browserInteractions;

    public LoginPage(IBrowserInteractions browserInteractions)
    {
        this.browserInteractions = browserInteractions;
    }

    private IWebElement UsernameField => this.browserInteractions.WaitAndReturnElement(UsernameFieldLocator);

    private IWebElement PasswordField => this.browserInteractions.WaitAndReturnElement(PasswordFieldLocator);

    private IWebElement LoginButton => this.browserInteractions.WaitAndReturnElement(LoginButtonLocator);

    public void GoToLoginPage() => this.browserInteractions.GoToUrl(Urls.LandingPage);

    public void LoginWithStandardUser()
    {
        this.UsernameField.SendKeys("standard_user");
        this.PasswordField.SendKeys("secret_sauce");
        this.LoginButton.ClickWithWait();
    }



}