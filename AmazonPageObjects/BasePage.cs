using AmazonDriver;
using OpenQA.Selenium;

namespace AmazonAutomation.AmazonPageObjects
{
    public class BasePage
    {
        // Declare a protected IWebDriver instance so it can be accessed by any class that inherits from BasePage
        // Initialize it with the Singleton instance of the WebDriver
        protected IWebDriver _driver = DriverInstance.Instance;
    }
}
