using ContactUS.SUT.Actions;
using NUnit.Framework;
using OpenQA.Selenium;

using TechTalk.SpecFlow;

namespace ContactUS.Steps
{
    [Binding]
    public class ContactUsSteps
    {
        public IWebDriver _driver;
        private readonly ContactUsActions _contactUsActions;

        public ContactUsSteps(IWebDriver webDriver)
        {
            _contactUsActions = new ContactUsActions(webDriver);
        }

        [Given(@"Contact Us page is displayed")]
        public void GivenContactUsPageIsDisplayed()
        {
            _contactUsActions.OpenContactPage();
        }

        [When(@"selects submit")]
        [When(@"Zach selects Submit")]
        public void WhenZachSelectsSubmit()
        {
            _contactUsActions.ClickOnSubmitButton();
        }

        [Then(@"a '(.*)'warnings should display")]
        public void ThenAWarningsShouldDisplay(string expected)
        {
            var actual = _contactUsActions.GetWarningMessageText(expected);
            Assert.That(actual, Is.EqualTo(expected), "Expected warning message did not match");
        }

        [When(@"Zach click on the country drop-down")]
        public void WhenZachClickOnTheCountryDrop_Down()
        {
            _contactUsActions.ClickOnCountryDropDown();
        }

        [Then(@"the country drop down should only display '(.*)'")]
        public void ThenTheCountryDropDownShouldOnlyDisplay(string expected)
        {
            var actual = _contactUsActions.GetCountryTextFromDropDown();
            Assert.That(actual, Is.EqualTo(expected), "Expected country did not match");
        }

        [Then(@"the state drop down should display '(.*)' state")]
        public void ThenTheStateDropDownShouldDisplayState(string expected)
        {
           var actual = _contactUsActions.GetStateText(expected);
            Assert.That(actual, Is.EqualTo(expected), "State did not match");
        }

        [When(@"selects United States as the country")]
        [When(@"Zach selects United States as the country")]
        public void WhenZachSelectsUnitedStatesAsTheCountry()
        {
            _contactUsActions.ClickOnCountryDropDown();
            _contactUsActions.ClickOnUnitedStateFromDropDown();
        }

        [When(@"zach enters '(.*)' as the first name")]
        public void WhenZachEntersAsTheFirstName(string firstName)
        {
            _contactUsActions.EnterFirstName(firstName);
        }

        [When(@"zach enters '(.*)' as the last name")]
        public void WhenZachEntersAsTheLastName(string lastName)
        {
            _contactUsActions.EnterLastName(lastName);
        }

        [When(@"'(.*)' as the email")]
        public void WhenAsTheEmail(string email)
        {
            _contactUsActions.EnterEmail(email);
        }

        [When(@"'(.*)' as the address")]
        public void WhenAsTheAddress(string address)
        {
            _contactUsActions.EnterAddress(address);
        }


        [When(@"selects '(.*)' as the state")]
        public void WhenSelectsAsTheState(string state)
        {
            _contactUsActions.SelectState(state);
        }


        [When(@"enters (.*) as the zip code")]
        public void WhenEntersAsTheZipCode(string zipcode)
        {
            _contactUsActions.EnterZipCode(zipcode);
        }

        [Then(@"a '(.*)' message should display")]
        public void ThenAMessageShouldDisplay(string expected)
        {
            var actual = _contactUsActions.GetRequestVerificationText();
            Assert.That(actual, Is.EqualTo(expected), "Message did not match or the request is not created successfully");
        }
    }
}