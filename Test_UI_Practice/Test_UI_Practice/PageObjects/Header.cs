using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Test_UI_Practice
{
    public class Header
    {
        protected IWebDriver _driver;
        protected WebDriverWait _w8;
        private By _headeradver = By.XPath("//img");
        private By _contactUs = By.LinkText("Contact us");
        private By _signIn = By.LinkText("Sign in");
        private By _logo = By.CssSelector(".logo");
        private By _searchString = By.Id("search_query_top");
        private By _searchMagnifier = By.Name("submit_search");
        private By _cart = By.CssSelector(".shopping_cart > a");
        private By _dropDownWomen = By.XPath("//a[contains(text(),'Women')]");
        private By _dropTops = By.XPath("//a[contains(text(),'Tops')]");
        private By _dropTshirts = By.XPath("//a[contains(text(),'T-shirts')]");
        private By _dropBlouses = By.XPath("//a[contains(text(),'Blouses')]");
        private By _dropDresses = By.XPath("//a[contains(text(),'Dresses')]");
        private By _dropCasualDresses = By.LinkText("Casual Dresses");
        private By _dropEveningDresses = By.LinkText("Evening Dresses");
        private By _dropSummerDresses = By.XPath("//a[contains(text(),'Summer Dresses')]");
        private By _dropDownDresses = By.XPath("//div[@id='block_top_menu']/ul/li[2]/a");
        private By _dropDownDressesCasual = By.XPath("//div[@id='block_top_menu']/ul/li[2]/ul/li/a");
        private By _dropDownDressesEvening = By.XPath("//div[@id='block_top_menu']/ul/li[2]/ul/li[2]/a");
        private By _dropDownDressesSummer = By.XPath("//div[@id='block_top_menu']/ul/li[2]/ul/li[3]/a");



        public Header clickHeaderBanner()
        {
            _driver.FindElement(_headeradver).Click();
            return this;
        }
        public Header searchString()
        {
            _driver.FindElement(_searchString);
            return this;
        }
        public Header searchAndAddString()
        {
            _driver.FindElement(_searchString).SendKeys("платье");
            return this;
        }
        public SearchResult searchAndSendString()
        {
            _driver.FindElement(_searchString).SendKeys("платье");
            _driver.FindElement(_searchString).SendKeys(Keys.Enter);
            return new SearchResult(_driver);
        }
        public SearchResult clickSearchMagnifier()
        {
            _driver.FindElement(_searchString).SendKeys("платье");
            _driver.FindElement(_searchMagnifier).Click();
            return new SearchResult(_driver);
        }
        public Header clickLogo()
        {
            _driver.FindElement(_logo).Click();
            return this;
        }
        public ContactUs clickHeaderContactUs()
        {
            _driver.FindElement(_contactUs).Click();
            return new ContactUs(_driver);
        }
        public SignIn clickHeaderSignIn()
        {
            _driver.FindElement(_signIn).Click();
            return new SignIn(_driver);
        }
        public Cart clickCart()
        {
            _driver.FindElement(_cart).Click();
            return new Cart(_driver);
        }
        public Header dropDownWomen()
        {
            Actions act = new Actions(_driver);
            IWebElement elem =_driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            return this;
        }
        public Header dropDownWomenClick()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            return this;
        }
        public Header dropDownWomenChoice_Tops()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropTops).Click();
            return new Tops(_driver);
        }
        public Header dropDownWomenChoice_Tshirts()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropTshirts).Click();
            return new Tshirts(_driver);
        }
        public Header dropDownWomenChoice_Blouses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropBlouses).Click();
            return new Blouses(_driver);
        }
        public Header dropDownWomenChoice_Dresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropDresses).Click();
            return new Dresses(_driver);
        }
        public Header dropDownWomenChoice_CasualDresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropCasualDresses).Click();
            return new CasualDresses(_driver);
        }
        public Header dropDownWomenChoice_EveningDresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropEveningDresses).Click();
            return new EveningDresses(_driver);
        }
        public Header dropDownWomenChoice_SummerDresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropSummerDresses).Click();
            return new SummerDresses(_driver);
        }
        public Header dropDownDresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownDresses);
            act.MoveToElement(elem).Perform();
            return this;
        }
        public Header dropDownDressesClick()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownDresses);
            act.MoveToElement(elem).Perform();
            return this;
        }
        public Header dropDownCasualDresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownDresses);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropDownDressesCasual).Click();
            return new CasualDresses(_driver);
        }
        public Header dropDownEveningDresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownDresses);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropDownDressesEvening).Click();
            return new EveningDresses(_driver);
        }
        public Header dropDownSummerDresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownDresses);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropDownDressesSummer).Click();
            return new SummerDresses(_driver);
        }
    }
}
