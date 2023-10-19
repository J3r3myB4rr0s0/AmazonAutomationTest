using NUnit.Framework;
using AmazonPageObjects;

namespace AmazonTests
{
    [TestFixture]
    // Define the HomePageTests class that inherits from BaseTests
    public class HomePageTests:BaseTests
    {
        // Initialize a new instance of the HomePage class to interact with Amazon's home page
        HomePage homePage = new HomePage();

        [Test]
        public void TestSelectCategory()
        {
            // Define the category to be selected in the test
            string category = "Baby";
            // Call the SelectCategory method from the HomePage class to perform the action
            homePage.SelectCategory(category);
        }
    }
}


