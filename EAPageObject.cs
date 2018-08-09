using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumFirstVSCode
{
    class EAPageObject
    {

        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement DdlTitleID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement TxtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement TxtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement TxtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement BtnSave { get; set; }

        public void FillUserForm(string initial, string firstName, string middleName)
        {
            TxtInitial.EnterText(initial);
            TxtFirstName.EnterText(firstName);
            TxtMiddleName.EnterText(middleName);
            BtnSave.Clicks();
        }
    }
}
