using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
// Делал Димас
namespace Test_UI_Practice.tests
{
    public class Authorization : Header
    {

        public Authorization(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _orderHistory = By.XPath("//div[@id='center_column']/div/div/ul/li/a/span");
        private readonly By _creditSlip = By.XPath("//div[@id='center_column']/div/div/ul/li[2]/a/span");
        private readonly By _myAddress = By.XPath("//div[@id='center_column']/div/div/ul/li[3]/a/span");
        private readonly By _personalInfo = By.XPath("//div[@id='center_column']/div/div/ul/li[4]/a/span");
        private readonly By _wishlist = By.CssSelector("lnk_wishlist span");
        private readonly By _home = By.XPath("//span[contains(.,' Home')]");

        public OrderHistory OrderHistoryClick()
        {
            _driver.FindElement(_orderHistory).Click();
            return new OrderHistory(_driver);
        }

        public CreditSlips CreditSlipClick()
        {
            _driver.FindElement(_creditSlip).Click();
            return new CreditSlips(_driver);
        }

        public MyAddress MyAddressClick()
        {
            _driver.FindElement(_myAddress).Click();
            return new MyAddress(_driver);
        }

        public PersonalInfo PersonalInfoClick()
        {
            _driver.FindElement(_personalInfo).Click();
            return new PersonalInfo(_driver);
        }

        public Wishlist WishlistClick()
        {
            _driver.FindElement(_wishlist).Click();
            return new Wishlist(_driver);
        }

        public HomePage HomeClick()
        {
            _driver.FindElement(_home).Click();
            return new HomePage(_driver);
        }

    }
}
