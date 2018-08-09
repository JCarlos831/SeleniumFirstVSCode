using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirstVSCode
{
    public static class SeleniumSetMethods
    {
        /// <summary>
        /// Extended method for entering text in the control
        /// </summary>
        /// <param name="element">Element.</param>
        /// <param name="value">Value.</param>
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        /// <summary>
        /// Click into a button, Checkbox, option, etc
        /// </summary>
        /// <param name="element">Element.</param>
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        /// <summary>
        /// Selecting a drop down control
        /// </summary>
        /// <param name="element">Element.</param>
        /// <param name="value">Value.</param>
        public static void SelectDropDown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}