using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AmazonDriver
{
    // Define a 'sealed' class, which means it cannot be inherited
    public sealed class DriverInstance
    {
        // Declare a nullable static instance of IWebDriver
        private static IWebDriver? _instance;

        // Private constructor ensures that no instance can be made from outside of this class
        private DriverInstance()
        {
        }

        // Public static property to access the WebDriver instance
        public static IWebDriver Instance
        {
            get
            {
                // If the instance is null, initialize it
                if (_instance == null)
                {
                    _instance = new ChromeDriver();
                }
                // Return the instance
                return _instance;
            }
        }
    }
}

