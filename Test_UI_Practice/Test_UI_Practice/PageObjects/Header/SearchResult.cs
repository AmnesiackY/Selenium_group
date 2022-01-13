using System;
using OpenQA.Selenium;

namespace Test_UI_Practice.tests
{
    public class SearchResult : Header
    {
        public SearchResult(IWebDriver driver) 
        {
            _driver = driver;
        }
    }
}
