using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
// Делал Димас
namespace Test_UI_Practice.tests
{
    public class PersonalInfo : Header
    {
        public PersonalInfo(IWebDriver driver)
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
        private readonly By _email = By.Id("email");
        private readonly By _currentPassword = By.Id("old-passwd");
        private readonly By _confirmation = By.Id("confirmation");
        private readonly By _saveButton = By.XPath("//span[contains(.,'Save')]");

        public PersonalInfo ChooseMaleGender()
        {
            _driver.FindElement(_genderMale).Click();
            return this;
        }

        public PersonalInfo ChooseFemaleGender()
        {
            _driver.FindElement(_genderFemale).Click();
            return this;
        }

        public PersonalInfo EnterFirstName(string firstname)
        {
            _driver.FindElement(_firstName).SendKeys(firstname);
            return this;
        }

        public PersonalInfo EnterLastName(string lastname)
        {
            _driver.FindElement(_lastName).SendKeys(lastname);
            return this;
        }

        public PersonalInfo EnterCurrentPassword(string password)
        {
            _driver.FindElement(_currentPassword).SendKeys(password);
            return this;
        }

        public PersonalInfo ChooseDayOfBirth(string day)
        {
            _driver.FindElement(_dayOfBirth).Click();
            _driver.FindElement(_dayOfBirth).SendKeys(day);
            _driver.FindElement(_dayOfBirth).SendKeys(Keys.Enter);
            return this;
        }

        public PersonalInfo ChooseMonthOfBirth(string month)
        {
            _driver.FindElement(_monthOfBirth).Click();
            _driver.FindElement(_monthOfBirth).SendKeys(month);
            _driver.FindElement(_monthOfBirth).SendKeys(Keys.Enter);
            return this;
        }

        public PersonalInfo ChooseYearOfBirth(string year)
        {
            _driver.FindElement(_yearOfBirth).Click();
            _driver.FindElement(_yearOfBirth).SendKeys(year);
            _driver.FindElement(_yearOfBirth).SendKeys(Keys.Enter);
            return this;
        }

        public PersonalInfo ChooseNewsSubscription()
        {
            _driver.FindElement(_news).Click();
            return this;
        }

        public PersonalInfo ChooseOffersSubscription()
        {
            _driver.FindElement(_offers).Click();
            return this;
        }

        public PersonalInfo EnterEmail(string email)
        {
            _driver.FindElement(_email).SendKeys(email);
            return this;
        }

        public PersonalInfo EnterNewPassword(string newpass)
        {
            _driver.FindElement(_password).SendKeys(newpass);
            return this;
        }

        public PersonalInfo ConfirmPassword(string confirm)
        {
            _driver.FindElement(_confirmation).SendKeys(confirm);
            return this;
        }

        public PersonalInfo SaveClick()
        {
            _driver.FindElement(_saveButton).Click();
            return this;
        }
    }
}
