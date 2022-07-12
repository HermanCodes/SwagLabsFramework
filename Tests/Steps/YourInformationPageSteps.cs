namespace SwagLabsFramework.Tests.Steps;

using Pages.Executors;
using Utility;

[Binding]
internal class YourInformationPageSteps
{
    private readonly YourInformationPage yourInformationPage;
    private readonly CommonPage commonPage;

    public YourInformationPageSteps(YourInformationPage yourInformationPage, CommonPage commonPage)
    {
        this.yourInformationPage = yourInformationPage;
        this.commonPage = commonPage;
    }

    [Given("I have entered my personal information")]
    [When(@"I enter my personal information")]
    public void WhenIEnterMyPersonalInformation()
    {
        this.yourInformationPage.FillYourInformationFieldAndContinue();
    }

    [Then(@"I am taken to the Your Information page")]
    public void ThenIAmTakenToTheYourInformationPage()
    {
        this.commonPage.GetTwitterIconHrefAttribute().Should().Be(Urls.YourInformationPage);
    }

    [Then(@"I am not taken to the Your Information page")]
    public void ThenIAmNotTakenToTheYourInformationPage()
    {
        this.commonPage.GetPageUrl().Should().NotBe(Urls.YourInformationPage);
    }
}