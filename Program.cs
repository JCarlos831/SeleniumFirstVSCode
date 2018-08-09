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
            // Initialize Driver
            PropertiesCollection.Driver = new ChromeDriver();

            // Navigate to Execute Automation demo page
            PropertiesCollection.Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            ExcelLib.PopulateInCollection("/Users/JuanCMontoya/Desktop/SeleniumTestData.xlsx");

            // Login to application via Excel sheet
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));
            pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "FirstName"), ExcelLib.ReadData(1, "MiddleName"));

            // // Login to application
            // LoginPageObject pageLogin = new LoginPageObject();
            // pageLogin.Login("Juan", "Montoya");

            // EAPageObject pageEA = new EAPageObject();
            // pageEA.FillUserForm("JCM", "Juan", "Carlos");

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
