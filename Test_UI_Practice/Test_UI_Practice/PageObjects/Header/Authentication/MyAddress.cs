using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
// Делал Димас
namespace Test_UI_Practice.tests
{
    public class MyAddress : Header
    {
        public MyAddress(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _backToAccount = By.XPath("//span[contains(.,' Back to your account.')]");
        private readonly By _backToHome = By.XPath("//span[contains(.,' Home')]");
        private readonly By _updateAddress = By.XPath("//span[contains(.,'Update')]");
        private readonly By _newAddress = By.XPath("//span[contains(.,'Add a new address')]");
        private readonly By _deleteAddress = By.XPath("//span[contains(.,'Delete')]");

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

        public MyAddress DeleteAddressClick()
        {
            _driver.FindElement(_deleteAddress).Click();
            return this;
        }

        public UpdateAddress UpdateAddressClick()
        {
            _driver.FindElement(_updateAddress).Click();
            return new UpdateAddress(_driver);
        }

        public NewAddress NewAddressClick()
        {
            _driver.FindElement(_newAddress).Click();
            return new NewAddress(_driver);
        }
    }
}
