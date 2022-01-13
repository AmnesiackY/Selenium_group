using System;
using OpenQA.Selenium;

namespace Test_UI_Practice.tests
{
    public class Blouses : Header
    {
        public Blouses(IWebDriver driver) 
        {
            _driver = driver;
        }
    }
}
