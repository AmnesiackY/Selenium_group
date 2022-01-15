using OpenQA.Selenium;
//Делал Ярык
namespace Test_UI_Practice.tests
{
    internal class PrestaShop : HomePage
    {
        public PrestaShop(IWebDriver driver) 
        {
        _driver = driver;
        }
    }
}
