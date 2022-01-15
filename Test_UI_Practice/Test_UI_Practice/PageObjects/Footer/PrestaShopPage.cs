using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
// Делал Димас
namespace Test_UI_Practice.tests
{
    public class PrestaShopPage : Footer
    {
        public PrestaShopPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
