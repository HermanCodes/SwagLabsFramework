using OpenQA.Selenium;

namespace SwagLabsFramework.Utility
{
    public static class ElementLocatorExtensions
    {
        public static string GetHrefAttribute(this IWebElement pageElement) => pageElement.GetAttribute("href");
    }
}