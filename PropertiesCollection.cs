using OpenQA.Selenium;

namespace SeleniumFirstVSCode
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }

    class PropertiesCollection
    {
        // Auto-Implemented Property
        public static IWebDriver Driver { get; set; }
    }
}