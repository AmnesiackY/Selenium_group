using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Test_UI_Practice.tests
{
    public class Cart : Header
    {
        public Cart(IWebDriver driver) 
        {
            _driver = driver;
        }
    }
}
