using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
// Делал Димас
namespace Test_UI_Practice.tests
{
    public class CreditSlips : Header
    {
        public CreditSlips(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _backToAccount = By.XPath("//span[contains(.,' Back to your account.')]");
        private readonly By _backToHome = By.XPath("//span[contains(.,' Home')]");

        public Authorization BackToAccountClick()
        {
            _driver.FindElement(_backToAccount).Click();
            return new Authorization(_driver);
        }

        public HomePage BackToHomeClick()
        {
            _driver.FindElement(_backToHome).Click();
            return new HomePage(_driver);
        }
    }
}
