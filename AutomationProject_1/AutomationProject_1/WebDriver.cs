using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using Shared;
namespace AutomationProject_1
{
    public sealed class WebDriverSingleton
    {
        private static IWebDriver instance = null;
        private WebDriverSingleton() { }

        public static IWebDriver GetInstance()
        {
            if (instance == null)
            {
                CommonLogic commonLogic = new CommonLogic();
                instance = new ChromeDriver(".");
                // Add any other steps in running the web app.
            }
            return instance;
        }
    }
}
