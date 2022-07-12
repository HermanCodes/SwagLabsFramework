namespace SwagLabsFramework.Tests.Steps;

using Pages.Executors;

[Binding]
internal class CheckoutOverviewPageSteps
{
    private readonly CheckoutOverviewPage checkoutOverviewPage;

    public CheckoutOverviewPageSteps(CheckoutOverviewPage checkoutOverviewPage)
    {
        this.checkoutOverviewPage = checkoutOverviewPage;
    }

    [When(@"I click the finish button on the overview page")]
    public void WhenIClickTheFinishButtonOnTheOverviewPage()
    {
        this.checkoutOverviewPage.ClickFinishButton();
    }
}