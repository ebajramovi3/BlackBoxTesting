using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;


namespace VVSDrugiDioProjekta.Source.Pages
{
    public class WebDriverSingleton
    {
        private static IWebDriver _webDriverInstance;

        // Private constructor to prevent instantiation
        private WebDriverSingleton() { }

        // Method to get the singleton instance of IWebDriver
        public static IWebDriver GetInstance()
        {
            if (_webDriverInstance == null)
            {
                InitializeWebDriver();
            }

            return _webDriverInstance;
        }

        // Method to initialize the WebDriver
        private static void InitializeWebDriver()
        {
            _webDriverInstance = new ChromeDriver();
        }

        // Method to close and quit the WebDriver instance
        public static void CloseWebDriver()
        {
            if (_webDriverInstance != null)
            {
                _webDriverInstance.Quit();
                _webDriverInstance = null;
            }
        }
    }
}
