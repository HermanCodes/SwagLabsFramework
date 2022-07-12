namespace SwagLabsFramework.Tests.Steps;

using Pages.Executors;
using Utility;

[Binding]
internal class ProductsPageSteps
{
    private readonly ProductsPage productsPage;
    private readonly CommonPage commonPage;

    public ProductsPageSteps(ProductsPage productsPage,CommonPage commonPage)
    {
        this.productsPage = productsPage;
        this.commonPage = commonPage;
    }

    [Given(@"I have clicked the cart button")]
    public void GivenIHaveClickedTheCartButton()
    {
        this.productsPage.ClickCartButton();
    }

    [Given(@"I have added a (.*) to my cart")]
    [When(@"I add a (.*) to my cart")]
    public void WhenIAddToMyCart(string item)
    {
        this.productsPage.ClickAddToCart(item);
    }

    [Then(@"I am taken to the Products page")]
    public void ThenIAmTakenToTheProductsPage()
    {
        this.commonPage.GetPageUrl().Should().Be(Urls.LandingPage);
    }
}