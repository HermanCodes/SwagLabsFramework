using OpenQA.Selenium;

namespace SwagLabsFramework.Utility
{
    public static class ElementInteractions
    {
        public static void ClickWithWait(this IWebElement element)
        {
            Thread.Sleep(200);
            element.Click();
        }
    }
}
