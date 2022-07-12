namespace SwagLabsFramework.Tests.Steps;

using Pages.Executors;
using Utility;

[Binding]
internal class CommonSteps
{
    private readonly CommonPage commonPage;

    public CommonSteps(CommonPage commonPage)
    {
        this.commonPage = commonPage;
    }

    [When(@"I click the logout button")]
    public void WhenIClickTheLogoutButton()
    {
        this.commonPage.Logout();
    }

    [Then(@"I can see a link to the Secret Sauce twitter page")]
    public void ThenICanSeeALinkToTheSecretSauceTwitterPage()
    {
        this.commonPage.GetTwitterIconHrefAttribute().Should().Be(Urls.SecretSauceTwitterPage);
    }
}