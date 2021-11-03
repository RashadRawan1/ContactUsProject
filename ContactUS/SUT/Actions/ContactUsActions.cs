using ContactUS.Core;
using ContactUS.SUT.PageObjects;
using OpenQA.Selenium;

namespace ContactUS.SUT.Actions
{
    public class ContactUsActions
    {
        private readonly IWebDriver _driver;
        private readonly ContactUsPage _contactUSPage = new ContactUsPage();
        private readonly Synchronizer _synchronizer = new Synchronizer();

        public ContactUsActions(IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        public void OpenContactPage()
        {
            _driver.Navigate().GoToUrl("https://interview-contact-us.azurewebsites.net/");
        }

        public void ClickOnSubmitButton()
        {
            _synchronizer.WaitAndClick(_driver, _contactUSPage.SubmitButton);
        }

        public string GetWarningMessageText(string warningtext)
        {
            return _synchronizer.WaitAndGetText(_driver, _contactUSPage.GetRequiredFieldWarningText(warningtext));
        }
        public void ClickOnCountryDropDown()
        {
            _synchronizer.WaitAndClick(_driver, _contactUSPage.Country);
        }

        public string GetCountryTextFromDropDown()
        {
            return _synchronizer.WaitAndGetText(_driver, _contactUSPage.UnitedState);
        }

        public void ClickOnUnitedStateFromDropDown()
        {
            _synchronizer.WaitAndClick(_driver, _contactUSPage.UnitedState);
        }

        public string GetStateText(string expected)
        {
          _synchronizer.WaitAndClick(_driver, _contactUSPage.State);
          return _synchronizer.WaitAndGetText(_driver, _contactUSPage.GetStateText(expected));
        }

        public void EnterFirstName(string firstName)
        {
            _driver.FindElement(_contactUSPage.FirstName).SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            _driver.FindElement(_contactUSPage.LastName).SendKeys(lastName);
        }

        public void EnterEmail(string email)
        {
            _driver.FindElement(_contactUSPage.Email).SendKeys(email);
        }

        public void EnterAddress(string address)
        {
            _driver.FindElement(_contactUSPage.Address).SendKeys(address);
        }

        public void SelectState(string state)
        {
            _synchronizer.WaitAndClick(_driver, _contactUSPage.State);
            _synchronizer.WaitAndClick(_driver, _contactUSPage.GetStateText(state));
        }

        public void EnterZipCode(string zipcode)
        {
            _driver.FindElement(_contactUSPage.Zip).SendKeys(zipcode.ToString());
        }

        public string GetRequestVerificationText()
        {
           return _synchronizer.WaitAndGetText(_driver, _contactUSPage.ThankyouTextMessage);
        }
    }
}
