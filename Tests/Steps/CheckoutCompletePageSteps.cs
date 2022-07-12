namespace SwagLabsFramework.Tests.Steps;

using FluentAssertions.Execution;
using Pages.Executors;
using Utility;

[Binding]
internal class CheckoutCompletePageSteps
{
    private readonly CheckoutCompletePage checkoutCompletePage;

    public CheckoutCompletePageSteps(CheckoutCompletePage checkoutCompletePage)
    {
        this.checkoutCompletePage = checkoutCompletePage;
    }

    [Then(@"I should be on the checkout complete page and see the checkout complete message")]
    public void ThenIShouldBeOnTheCheckoutCompletePageAndSeeTheCheckoutCompleteMessage()
    {
        using (new AssertionScope())
        {
            this.checkoutCompletePage.GetPageUrl().Should().Be(Urls.CheckoutCompletePageUrl);
            this.checkoutCompletePage.CheckMessageIsDisplayed().Should().BeTrue();
        }
    }
}