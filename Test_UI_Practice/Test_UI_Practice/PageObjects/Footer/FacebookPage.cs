using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Test_UI_Practice.tests
{
    public class FacebookPage : Footer
    {
        public FacebookPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
