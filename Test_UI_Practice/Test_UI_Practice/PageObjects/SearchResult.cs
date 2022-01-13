using System;
using OpenQA.Selenium;

namespace Test_UI_Practice
{
    public class SearchResult : Header
    {
        public SearchResult(IWebDriver driver) 
        {
            _driver = driver;
        }
    }
}
