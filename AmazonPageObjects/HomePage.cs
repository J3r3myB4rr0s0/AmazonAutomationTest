using AmazonAutomation.AmazonPageObjects;
using OpenQA.Selenium;

namespace AmazonPageObjects
{
    public class HomePage:BasePage
    {
        public IWebElement CategorySelector => _driver.FindElement(By.Id("searchDropdownBox"));

        // Method to select a category from the dropdown
        public void SelectCategory(string category)
        {
            try
            {
                // Click the category dropdown to reveal the options
                CategorySelector.Click();

                // Find all 'option' elements within the category selector using CSS selector
                var options = CategorySelector.FindElements(By.CssSelector("option"));

                // Create a list to store the text of each 'option' element
                List<string> optionTexts = options.Select(opt => opt.Text).ToList();

                // Check if the desired category exists in the list
                if (optionTexts.Contains(category))
                {
                    // Use foreach loop to iterate through options
                    foreach (var option in options)
                    {
                        // If the option's text matches the desired category
                        if (option.Text == category)
                        {
                            // Click the option
                            option.Click();

                            // Exit the loop
                            break;
                        }
                    }
                }
                else
                {
                    // Throw an exception if the category does not exist
                    throw new NoSuchElementException($"Category {category} not found");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
