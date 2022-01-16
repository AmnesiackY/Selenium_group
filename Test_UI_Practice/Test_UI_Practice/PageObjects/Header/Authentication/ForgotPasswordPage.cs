using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
// Делал Димас
namespace Test_UI_Practice.tests
{
    public class ForgotPasswordPage : Header
    {
        public ForgotPasswordPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _email = By.Id("email");
        private readonly By _retrieve = By.XPath("//span[contains(.,'Retrieve Password')]");

        public ForgotPasswordPage EnterEmail(string email)
        {
            _driver.FindElement(_email).SendKeys(email);
            return this;
        }

        public ForgotPasswordPage RetrieveClick()
        {
            _driver.FindElement(_retrieve).Click();
            return this;
        }
    }
}
