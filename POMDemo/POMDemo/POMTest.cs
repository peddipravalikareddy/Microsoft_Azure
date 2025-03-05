using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POMDemo.Pages;

namespace POMDemo
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
        public void TestWithPOM()
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            LoginPage loginPage = new LoginPage(driver);
            loginPage.ClickLogin();
            loginPage.Login("admin", "password");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}