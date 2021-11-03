using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace ContactUS.Core
{
    public class Synchronizer
    {
        public string WaitAndGetText(IWebDriver Driver, By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            return wait.Until(ExpectedConditions.ElementIsVisible(locator)).Text;
        }
        public void WaitAndClick(IWebDriver Driver, By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator)).Click();
        }
    }
}
