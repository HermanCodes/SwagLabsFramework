namespace SwagLabsFramework.Tests.Steps;

using Pages.Executors;
using Utility;

[Binding]
internal class LoginPageSteps
{
    private readonly LoginPage loginPage;
    private readonly CommonPage commonPage;

    public LoginPageSteps(LoginPage loginPage, CommonPage commonPage)
    {
        this.loginPage = loginPage;
        this.commonPage = commonPage;
    }

    [Given(@"I am logged in as an authorised customer")]
    public void GivenIAmLoggedInAsAnAuthorisedCustomer()
    {
        this.loginPage.GoToLoginPage();
        this.loginPage.LoginWithStandardUser();
    }

    [Then(@"I am successfully logged out")]
    public void ThenIAmSuccessfullyLoggedOut()
    {
        this.commonPage.GetPageUrl().Should().NotBe(Urls.LandingPage);
    }
}