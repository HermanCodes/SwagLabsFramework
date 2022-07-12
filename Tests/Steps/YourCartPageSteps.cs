namespace SwagLabsFramework.Tests.Steps;

using Pages.Executors;

[Binding]
internal class YourCartPageSteps
{
    private readonly YourCartPage yourCartPage;

    public YourCartPageSteps(YourCartPage yourCartPage)
    {
        this.yourCartPage = yourCartPage;
    }

    [StepDefinition(@"I click the checkout button")]
    public void WhenIClickTheCheckoutButton()
    {
        this.yourCartPage.ClickCheckoutButton();
    }

    [StepDefinition(@"I click the (.*) remove button")]
    public void WhenIClickTheRemoveButton(string item)
    {
        this.yourCartPage.ClickRemoveButton(item);
    }

    [When(@"I click the continue shopping button")]
    public void WhenIClickTheContinueShoppingButton()
    {
        this.yourCartPage.ClickContinueShoppingButton();
    }

    [Then(@"my cart should be empty")]
    public void ThenMyCartShouldBeEmpty()
    {
        this.yourCartPage.BasketIsEmpty().Should().BeTrue();
    }
}