using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowContactUsProject.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs(_driver);
            _driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void TearDown(ScenarioContext context)
        {
            _driver.Quit();
        }
    }
}