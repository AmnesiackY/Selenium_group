using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Test_UI_Practice
{
    public class HomePage : Header
    {
        public HomePage(IWebDriver driver) 
        {
            _driver = driver;
            _w8 = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
        }
    }
}
