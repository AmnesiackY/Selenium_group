using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
//Делал Ярык
namespace Test_UI_Practice.tests
{
    public class Header
    {
        protected IWebDriver _driver;
        private readonly By _headeradver = By.XPath("//img");
        private readonly By _contactUs = By.LinkText("Contact us");
        private readonly By _signIn = By.LinkText("Sign in");
        private readonly By _logo = By.CssSelector(".logo");
        private readonly By _searchString = By.Id("search_query_top");
        private readonly By _searchMagnifier = By.Name("submit_search");
        private readonly By _cart = By.CssSelector(".shopping_cart > a");
        private readonly By _dropDownWomen = By.XPath("//a[contains(text(),'Women')]");
        private readonly By _dropTops = By.XPath("//a[contains(text(),'Tops')]");
        private readonly By _dropTshirts = By.XPath("//a[contains(text(),'T-shirts')]");
        private readonly By _dropBlouses = By.XPath("//a[contains(text(),'Blouses')]");
        private readonly By _dropDresses = By.XPath("//a[contains(text(),'Dresses')]");
        private readonly By _dropCasualDresses = By.LinkText("Casual Dresses");
        private readonly By _dropEveningDresses = By.LinkText("Evening Dresses");
        private readonly By _dropSummerDresses = By.XPath("//a[contains(text(),'Summer Dresses')]");
        private readonly By _dropDownDresses = By.XPath("//div[@id='block_top_menu']/ul/li[2]/a");
        private readonly By _dropDownDressesCasual = By.XPath("//div[@id='block_top_menu']/ul/li[2]/ul/li/a");
        private readonly By _dropDownDressesEvening = By.XPath("//div[@id='block_top_menu']/ul/li[2]/ul/li[2]/a");
        private readonly By _dropDownDressesSummer = By.XPath("//div[@id='block_top_menu']/ul/li[2]/ul/li[3]/a");


        public Header ClickHeaderBanner()
        {
            _driver.FindElement(_headeradver).Click();
            return this;
        }
        public Header SearchString()
        {
            _driver.FindElement(_searchString);
            return this;
        }
        public Header SearchAndAddString()
        {
            _driver.FindElement(_searchString).SendKeys("платье");
            return this;
        }
        public SearchResult SearchAndSendString()
        {
            _driver.FindElement(_searchString).SendKeys("платье");
            _driver.FindElement(_searchString).SendKeys(Keys.Enter);
            return new SearchResult(_driver);
        }
        public SearchResult ClickSearchMagnifier()
        {
            _driver.FindElement(_searchString).SendKeys("платье");
            _driver.FindElement(_searchMagnifier).Click();
            return new SearchResult(_driver);
        }
        public Header ClickLogo()
        {
            _driver.FindElement(_logo).Click();
            return this;
        }
        public ContactUs ClickHeaderContactUs()
        {
            _driver.FindElement(_contactUs).Click();
            return new ContactUs(_driver);
        }
        public SignIn ClickHeaderSignIn()
        {
            _driver.FindElement(_signIn).Click();
            return new SignIn(_driver);
        }
        public Cart ClickCart()
        {
            _driver.FindElement(_cart).Click();
            return new Cart(_driver);
        }
        public Header DropDownWomen()
        {
            Actions act = new Actions(_driver);
            IWebElement elem =_driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            return this;
        }
        public Header DropDownWomenClick()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            return this;
        }
        public Header DropDownWomenChoice_Tops()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropTops).Click();
            return new TopsCategory(_driver);
        }
        public Header DropDownWomenChoice_Tshirts()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropTshirts).Click();
            return new TshirtsCategory(_driver);
        }
        public Header DropDownWomenChoice_Blouses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropBlouses).Click();
            return new BlousesCategory(_driver);
        }
        public Header DropDownWomenChoice_Dresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropDresses).Click();
            return new DressesCatagory(_driver);
        }
        public Header DropDownWomenChoice_CasualDresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropCasualDresses).Click();
            return new CasualDressesCategory(_driver);
        }
        public Header DropDownWomenChoice_EveningDresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropEveningDresses).Click();
            return new EveningDressesCategory(_driver);
        }
        public Header DropDownWomenChoice_SummerDresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownWomen);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropSummerDresses).Click();
            return new SummerDressesCategory(_driver);
        }
        public Header DropDownDresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownDresses);
            act.MoveToElement(elem).Perform();
            return this;
        }
        public Header DropDownDressesClick()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownDresses);
            act.MoveToElement(elem).Perform();
            return new Dress_mainCategory(_driver);
        }
        public Header DropDownCasualDresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownDresses);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropDownDressesCasual).Click();
            return new DressesCasualCategory(_driver);
        }
        public Header DropDownEveningDresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownDresses);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropDownDressesEvening).Click();
            return new DressesEveningCategory(_driver);
        }
        public Header DropDownSummerDresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropDownDresses);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_dropDownDressesSummer).Click();
            return new DressesSummerCategory(_driver);
        }
    }
}
