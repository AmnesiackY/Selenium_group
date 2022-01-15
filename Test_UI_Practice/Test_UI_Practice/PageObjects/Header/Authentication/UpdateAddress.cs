using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
// Делал Димас
namespace Test_UI_Practice.tests
{
    public class UpdateAddress : Header
    {
        public UpdateAddress(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _firstName = By.Id("customer_firstname");
        private readonly By _lastName = By.Id("customer_lastname");
        private readonly By _company = By.Id("company");
        private readonly By _address1 = By.Id("address1");
        private readonly By _address2 = By.Id("address2");
        private readonly By _city = By.Id("city");
        private readonly By _state = By.Id("id_state");
        private readonly By _postcode = By.Id("postcode");
        private readonly By _country = By.Id("id_country");
        private readonly By _otherInfo = By.Id("other");
        private readonly By _phone = By.Id("phone");
        private readonly By _phoneMobile = By.Id("phone_mobile");
        private readonly By _alias = By.Id("alias");
        private readonly By _saveButton = By.XPath("//p[2]/button/span");
        private readonly By _back = By.XPath("//span[contains(.,' Back to your addresses')]");

        public UpdateAddress EnterFirstName(string firstname)
        {
            _driver.FindElement(_firstName).SendKeys(firstname);
            return this;
        }

        public UpdateAddress EnterLastName(string lastname)
        {
            _driver.FindElement(_lastName).SendKeys(lastname);
            return this;
        }

        public UpdateAddress EnterCompanyName(string company)
        {
            _driver.FindElement(_company).SendKeys(company);
            return this;
        }

        public UpdateAddress EnterAddress1(string address)
        {
            _driver.FindElement(_address1).SendKeys(address);
            return this;
        }

        public UpdateAddress EnterAddress2(string address)
        {
            _driver.FindElement(_address2).SendKeys(address);
            return this;
        }

        public UpdateAddress EnterCity(string city)
        {
            _driver.FindElement(_city).SendKeys(city);
            return this;
        }

        public UpdateAddress EnterState(string state)
        {
            _driver.FindElement(_state).SendKeys(state);
            return this;
        }

        public UpdateAddress EnterPostcode(string postcode)
        {
            _driver.FindElement(_postcode).SendKeys(postcode);
            return this;
        }

        public UpdateAddress EnterCountry(string country)
        {
            _driver.FindElement(_country).SendKeys(country);
            return this;
        }

        public UpdateAddress EnterOtherInfo(string other)
        {
            _driver.FindElement(_otherInfo).SendKeys(other);
            return this;
        }

        public UpdateAddress EnterPhone(string phone)
        {
            _driver.FindElement(_phone).SendKeys(phone);
            return this;
        }

        public UpdateAddress EnterPhoneMobile(string mobile)
        {
            _driver.FindElement(_phoneMobile).SendKeys(mobile);
            return this;
        }

        public UpdateAddress EnterAlias(string alias)
        {
            _driver.FindElement(_alias).SendKeys(alias);
            return this;
        }

        public MyAddress SaveClick()
        {
            _driver.FindElement(_saveButton).Click();
            return new MyAddress(_driver);
        }

        public MyAddress BackToAddressessClick()
        {
            _driver.FindElement(_back).Click();
            return new MyAddress(_driver);
        }
    }
}
