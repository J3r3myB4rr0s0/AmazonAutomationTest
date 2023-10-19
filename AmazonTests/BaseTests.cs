using AmazonDriver;
using AmazonAutomation.Configuration;
using NUnit.Framework;

namespace AmazonTests
{
    public class BaseTests
    {
        [SetUp]
        public void Setup()
        {
            // Navigate to Amazon's home page before running each test
            DriverInstance.Instance.Navigate().GoToUrl(Configuration.BaseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            // Close the current browser window
            DriverInstance.Instance.Close();
            // Quit the WebDriver session, effectively closing all browser windows
            DriverInstance.Instance.Quit();
        }
    }
}

