using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumFirstVSCode;

namespace SeleniumFirst
{

    public class MainClass
    {
        // Create the reference for our browser
         IWebDriver driver = new FirefoxDriver("/Users/JuanCMontoya/Desktop");

        public static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            // Navigate to Google's home page
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL in Chrome");
        }

        [Test]
        public void ExecuteTest()
        {
            // Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            // Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "JCM", "Name");

            Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDL(driver, "TitleId", "Id"));

            Console.WriteLine("The value from Initial is: " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));

            // Click
            SeleniumSetMethods.Click(driver, "Save", "Name");
        }

        [TearDown]
        public void CleanUp()
        {
            // Close browser
            driver.Close();
            Console.WriteLine("Closed Browser");
        }
    }
}