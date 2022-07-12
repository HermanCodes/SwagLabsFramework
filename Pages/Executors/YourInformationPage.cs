namespace SwagLabsFramework.Pages.Executors;

using Locators;
using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using SwagLabsFramework.Utility;

internal class YourInformationPage : YourInformationPageLocators
{
    private readonly IBrowserInteractions browserInteractions;

    public YourInformationPage(IBrowserInteractions browserInteractions)
    {
        this.browserInteractions = browserInteractions;
    }

    private IWebElement FirstNameInputField => this.browserInteractions.WaitAndReturnElement(FirstNameFieldLocator);
    private IWebElement LastNameInputField => this.browserInteractions.WaitAndReturnElement(LastNameFieldLocator);
    private IWebElement PostCodeInputField => this.browserInteractions.WaitAndReturnElement(PostCodeFieldLocator);
    private IWebElement ContinueButton => this.browserInteractions.WaitAndReturnElement(ContinueButtonLocator);

    public void FillYourInformationFieldAndContinue()
    {
        this.FirstNameInputField.SendKeys("TestFirstName");
        this.LastNameInputField.SendKeys("TestLastName");
        this.PostCodeInputField.SendKeys("NR70WG");
        this.ContinueButton.ClickWithWait();
    }
}