using System;
using OpenQA.Selenium;

namespace Test_UI_Practice
{
    public class Blouses : Header
    {
        public Blouses(IWebDriver driver) 
        {
            _driver = driver;
        }
    }
}
