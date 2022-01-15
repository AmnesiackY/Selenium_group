using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Test_UI_Practice.tests
{
    public class AboutUsPage : Footer
    {
        public AboutUsPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
