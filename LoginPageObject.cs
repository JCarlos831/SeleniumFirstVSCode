using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumFirstVSCode
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement TxtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement BtnLogin { get; set; }

        public EAPageObject Login(string userName, string password)
        {
            // UserName
            TxtUserName.EnterText(userName);
            // Password
            TxtPassword.EnterText(password);
            // Click Button
            BtnLogin.Submit();

            // Return the page object
            return new EAPageObject();
        }
    }
}
