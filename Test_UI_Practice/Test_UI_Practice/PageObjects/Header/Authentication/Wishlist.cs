using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
// Делал Димас
namespace Test_UI_Practice.tests
{
    public class Wishlist : Header
    {
        public Wishlist(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _wishName = By.Id("name");
        private readonly By _submitWish = By.XPath("//span[contains(.,'Save')]");
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

        public Wishlist EnterFirstName(string wish)
        {
            _driver.FindElement(_wishName).SendKeys(wish);
            return this;
        }

        public Wishlist SaveClick()
        {
            _driver.FindElement(_submitWish).Click();
            return this;
        }
    }
}
