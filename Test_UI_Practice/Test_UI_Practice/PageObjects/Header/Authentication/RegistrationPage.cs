using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
// Делал Димас
namespace Test_UI_Practice.tests
{
    public class RegistrationPage : Header
    {
        public RegistrationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _genderMale = By.Id("id_gender1");
        private readonly By _genderFemale = By.Id("id_gender2");
        private readonly By _firstName = By.Id("customer_firstname");
        private readonly By _lastName = By.Id("customer_lastname");
        private readonly By _password = By.Id("passwd");
        private readonly By _dayOfBirth = By.Id("days");
        private readonly By _monthOfBirth = By.Id("months");
        private readonly By _yearOfBirth = By.Id("years");
        private readonly By _news = By.Id("newsletter");
        private readonly By _offers = By.Id("optin");
        private readonly By _addressFirstName = By.Id("firstname");
        private readonly By _addressLastName = By.Id("lastname");
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
        private readonly By _registerButton = By.XPath("//span[contains(.,'Register')]");

        public RegistrationPage ChooseMaleGender()
        {
            _driver.FindElement(_genderMale).Click();
            return this;
        }

        public RegistrationPage ChooseFemaleGender()
        {
            _driver.FindElement(_genderFemale).Click();
            return this;
        }

        public RegistrationPage EnterFirstName(string firstname)
        {
            _driver.FindElement(_firstName).SendKeys(firstname);
            return this;
        }

        public RegistrationPage EnterLastName(string lastname)
        {
            _driver.FindElement(_lastName).SendKeys(lastname);
            return this;
        }

        public RegistrationPage EnterPassword(string password)
        {
            _driver.FindElement(_password).SendKeys(password);
            return this;
        }

        public RegistrationPage ChooseDayOfBirth(string day)
        {
            _driver.FindElement(_dayOfBirth).Click();
            _driver.FindElement(_dayOfBirth).SendKeys(day);
            _driver.FindElement(_dayOfBirth).SendKeys(Keys.Enter);
            return this;
        }

        public RegistrationPage ChooseMonthOfBirth(string month)
        {
            _driver.FindElement(_monthOfBirth).Click();
            _driver.FindElement(_monthOfBirth).SendKeys(month);
            _driver.FindElement(_monthOfBirth).SendKeys(Keys.Enter);
            return this;
        }

        public RegistrationPage ChooseYearOfBirth(string year)
        {
            _driver.FindElement(_yearOfBirth).Click();
            _driver.FindElement(_yearOfBirth).SendKeys(year);
            _driver.FindElement(_yearOfBirth).SendKeys(Keys.Enter);
            return this;
        }

        public RegistrationPage ChooseNewsSubscription()
        {
            _driver.FindElement(_news).Click();
            return this;
        }

        public RegistrationPage ChooseOffersSubscription()
        {
            _driver.FindElement(_offers).Click();
            return this;
        }

        public RegistrationPage EnterAddressFirstName(string firstname)
        {
            _driver.FindElement(_addressFirstName).SendKeys(firstname);
            return this;
        }

        public RegistrationPage EnterAddressLastName(string lastname)
        {
            _driver.FindElement(_addressLastName).SendKeys(lastname);
            return this;
        }

        public RegistrationPage EnterCompanyName(string company)
        {
            _driver.FindElement(_company).SendKeys(company);
            return this;
        }

        public RegistrationPage EnterAddress1(string address)
        {
            _driver.FindElement(_address1).SendKeys(address);
            return this;
        }

        public RegistrationPage EnterAddress2(string address)
        {
            _driver.FindElement(_address2).SendKeys(address);
            return this;
        }

        public RegistrationPage EnterCity(string city)
        {
            _driver.FindElement(_city).SendKeys(city);
            return this;
        }

        public RegistrationPage EnterState(string state)
        {
            _driver.FindElement(_state).SendKeys(state);
            return this;
        }

        public RegistrationPage EnterPostcode(string postcode)
        {
            _driver.FindElement(_postcode).SendKeys(postcode);
            return this;
        }

        public RegistrationPage EnterCountry(string country)
        {
            _driver.FindElement(_country).SendKeys(country);
            return this;
        }

        public RegistrationPage EnterOtherInfo(string other)
        {
            _driver.FindElement(_otherInfo).SendKeys(other);
            return this;
        }

        public RegistrationPage EnterPhone(string phone)
        {
            _driver.FindElement(_phone).SendKeys(phone);
            return this;
        }

        public RegistrationPage EnterPhoneMobile(string mobile)
        {
            _driver.FindElement(_phoneMobile).SendKeys(mobile);
            return this;
        }

        public RegistrationPage EnterAlias(string alias)
        {
            _driver.FindElement(_alias).SendKeys(alias);
            return this;
        }

        public RegistrationPage RegistrationConfirm()
        {
            _driver.FindElement(_registerButton).Click();
            return this;
        }


    }
}
