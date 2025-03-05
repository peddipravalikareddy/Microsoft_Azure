using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using HTMLForm;

namespace HTMLForm
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void WorkingWithAdvancedControls()
        {
            //driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.Navigate().GoToUrl("file:///C:/Users/User/OneDrive/Desktop/WebAPI/HTMLForm/TestPage.html");
            SeleniumHelper.EnterText(driver.FindElement(By.Id("name")), "Pravali");
            SeleniumHelper.EnterText(driver.FindElement(By.Id("email")), "ppr08@outlook.com");
            SeleniumHelper.EnterText(driver.FindElement(By.Id("doj")), "31-05-2003");
            SeleniumHelper.Click(driver.FindElement(By.CssSelector("input[name='gender'][value='female']")));
            SeleniumHelper.SelectDropDownByText(driver.FindElement(By.Id("city")), "Hyderabad");
            SeleniumHelper.EnterText(driver.FindElement(By.Id("designation")), "Analyst");
            SeleniumHelper.MultiSelectElements(driver.FindElement(By.Id("skills")), ["testing", ".net", "cloud"]);

            var getSelectedOptions = SeleniumHelper.GetAllSelectedLists(driver.FindElement(By.Id("skills")));
            getSelectedOptions.ForEach(Console.WriteLine);

            SeleniumHelper.Click(driver.FindElement(By.CssSelector("input[name='hobbies'][value='Reading Books']")));
            SeleniumHelper.Click(driver.FindElement(By.CssSelector("input[name='hobbies'][value='Playing Chess']")));

            var getSelectedHobbies = SeleniumHelper.GetAllCheckedCheckboxes(driver, By.Name("hobbies"));
            getSelectedHobbies.ForEach(Console.WriteLine);

            // Clicking the Register Button
            SeleniumHelper.Click(driver.FindElement(By.CssSelector("button[type='submit']")));

            // Validation: Ensure form submission redirects to a success page or displays a confirmation message
            Thread.Sleep(2000);  // Wait for form submission response
            bool isSubmissionSuccessful = driver.PageSource.Contains("Thank you for registering") || driver.Url.Contains("success");
            Assert.IsTrue(isSubmissionSuccessful, "Form submission failed.");
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                try
                {
                    driver.Close();
                }
                catch (Exception)
                {
                    // Log the exception if necessary
                }
                finally
                {
                    driver.Quit();
                }
            }
        }
    }
}