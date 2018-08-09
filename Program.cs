using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirstVSCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.Driver = new ChromeDriver();

            // Navigate to Execute Automation demo page
            PropertiesCollection.Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            // Login to application
            LoginPageObject pageLogin = new LoginPageObject();
            pageLogin.Login("Juan", "Montoya");

            EAPageObject pageEA = new EAPageObject();
            pageEA.FillUserForm("JCM", "Juan", "Carlos");

            //// Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            //// Inital
            //SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            //// Click
            //SeleniumSetMethods.Click("Save", PropertyType.Name);

            //Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));
            //Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));
        }

        [TearDown]
        public void CleanUp()
        {
            // Close browser
            PropertiesCollection.Driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
