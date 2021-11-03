using OpenQA.Selenium;

namespace ContactUS.SUT.PageObjects
{
    public class ContactUsPage
    {
        public By FirstName = By.Id("firstName");
        public By LastName = By.Id("lastName");
        public By Email = By.Id("email");
        public By Address = By.Id("address");
        public By Address2 = By.Id("address2");
        public By Country = By.Id("country");
        public By State = By.Id("state");
        public By Zip = By.Id("zip");
        public By SubmitButton = By.CssSelector("button");
        public By GetRequiredFieldWarningText(string warningText) => By.XPath($"//div[contains(text(),'{warningText}')]");
        public By UnitedState = By.XPath("//*[contains(text(),'United States')]");
        public By GetStateText(string state) => By.XPath($"//*[contains(text(),'{state}')]");
        public By ThankyouTextMessage = By.XPath("//*[contains(text(),'Thank you for your interest!')]");
    }
}