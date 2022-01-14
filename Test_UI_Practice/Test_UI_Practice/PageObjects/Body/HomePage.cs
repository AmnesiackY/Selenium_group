using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Test_UI_Practice.tests
{
    public class HomePage : Header
    {
        public HomePage(IWebDriver driver) 
        {
            _driver = driver;
        }
        //check commits in Git from new branch
    }
}
