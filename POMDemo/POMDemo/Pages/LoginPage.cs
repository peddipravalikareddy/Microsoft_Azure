using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMDemo.Pages
{
    class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement LoginLink => driver.FindElement(By.Id("loginLink"));
        IWebElement TxtUserName => driver.FindElement(By.Id("UserName"));
        IWebElement TxtPassword => driver.FindElement(By.Id("Password"));
        IWebElement BtnLogin => driver.FindElement(By.CssSelector(".btn"));
        public void ClickLogin()
        {
            LoginLink.Click();
        }
        public void Login(string username, string password)
        {
            TxtUserName.SendKeys(username);
            TxtPassword.SendKeys(password);
            BtnLogin.Submit();
        }

    }
}