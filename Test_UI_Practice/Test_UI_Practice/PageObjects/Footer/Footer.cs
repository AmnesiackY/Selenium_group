using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
//Делал Димас
namespace Test_UI_Practice.tests
{
    public class Footer : Header
    {
        //protected IWebDriver _driver;
        private readonly By _newsletter = By.Id("newsletter-input");
        private readonly By _newsletterSubmitButton = By.Name("submitNewsletter");
        protected readonly By _facebook = By.XPath("//a[contains(@href, 'https://www.facebook.com/groups/525066904174158/')]");
        protected readonly By _youtube = By.XPath("//a[contains(@href, 'https://www.youtube.com/channel/UCHl59sI3SRjQ-qPcTrgt0tA')]");
        protected readonly By _twitter = By.XPath("//a[contains(@href, 'https://twitter.com/seleniumfrmwrk')]");
        protected readonly By _google = By.XPath("//a[contains(@href, 'https://plus.google.com/111979135243110831526/posts')]");
        protected readonly By _pinterest = By.XPath("//button[contains(.,' Pinterest')]");
        private readonly By _categories = By.XPath("//h4[contains(.,'Categories')]");
        private readonly By _categoriesWomen = By.LinkText("Women");
        private readonly By _specials = By.LinkText("Specials");
        private readonly By _newProducts = By.LinkText("New products");
        private readonly By _bestSellers = By.LinkText("Best sellers");
        private readonly By _ourStores = By.LinkText("Our stores");
        private readonly By _contactUs = By.LinkText("Contact us");
        private readonly By _termsAndConditions = By.LinkText("Terms and conditions of use");
        private readonly By _aboutUs = By.LinkText("About us");
        private readonly By _sitemap = By.LinkText("Sitemap");
        private readonly By _myAccount = By.LinkText("My account");
        private readonly By _myOrders = By.LinkText("My orders");
        private readonly By _myCreditSlips = By.LinkText("My credit slips");
        private readonly By _myAddresses = By.LinkText("My addresses");
        private readonly By _myPersonalInfo = By.LinkText("My personal info");
        private readonly By _ecommerce = By.LinkText("Ecommerce software by PrestaShop™");

        public Footer EnterEmail(string email)
        {
            _driver.FindElement(_newsletter).SendKeys(email);
            return this;
        }

        public Footer SubmitEmailClick()
        {
            _driver.FindElement(_newsletterSubmitButton).Click();
            return this;
        }

        public FacebookPage FacebookClick()
        {
            _driver.FindElement(_facebook).Click();
            return new FacebookPage(_driver);
        }

        public TwitterPage TwitterClick()
        {
            _driver.FindElement(_twitter).Click();
            return new TwitterPage(_driver);
        }

        public YoutubePage YoutubeClick()
        {
            _driver.FindElement(_youtube).Click();
            return new YoutubePage(_driver);
        }

        public GooglePage GoogleClick()
        {
            _driver.FindElement(_google).Click();
            return new GooglePage(_driver);
        }

        public CategoriesPage CategoriesClick()
        {
            _driver.FindElement(_categories).Click();
            return new CategoriesPage(_driver);
        }

        public WomenPageCategory WomenClick()
        {
            _driver.FindElement(_categoriesWomen).Click();
            return new WomenPageCategory(_driver);
        }

        public SpecialsPage SpecialsClick()
        {
            _driver.FindElement(_specials).Click();
            return new SpecialsPage(_driver);
        }

        public NewProductsPage NewProductsClick()
        {
            _driver.FindElement(_newProducts).Click();
            return new NewProductsPage(_driver);
        }

        public BestSellersPage BestSellersClick()
        {
            _driver.FindElement(_bestSellers).Click();
            return new BestSellersPage(_driver);
        }

        public OurStoresClick OurStoresClick()
        {
            _driver.FindElement(_ourStores).Click();
            return new OurStoresClick(_driver);
        }

        public ContactUs ContactUsClick()
        {
            _driver.FindElement(_contactUs).Click();
            return new ContactUs(_driver);
        }

        public TermsAndConditionsPage TermsClick()
        {
            _driver.FindElement(_termsAndConditions).Click();
            return new TermsAndConditionsPage(_driver);
        }

        public AboutUsPage AboutUsClick()
        {
            _driver.FindElement(_aboutUs).Click();
            return new AboutUsPage(_driver);
        }

        public SiteMapPage SiteMapClick()
        {
            _driver.FindElement(_sitemap).Click();
            return new SiteMapPage(_driver);
        }

        public SignIn MyAccountClick()
        {
            _driver.FindElement(_myAccount).Click();
            return new SignIn(_driver);
        }

        public OrderPage OrderClick()
        {
            _driver.FindElement(_myOrders).Click();
            return new OrderPage(_driver);
        }

        public CreditSlipPage CreditSlipClick()
        {
            _driver.FindElement(_myCreditSlips).Click();
            return new CreditSlipPage(_driver);
        }

        public AddressesPage AddressesClick()
        {
            _driver.FindElement(_myAddresses).Click();
            return new AddressesPage(_driver);
        }

        public PersonalInfoPage PersonalInfoClick()
        {
            _driver.FindElement(_myPersonalInfo).Click();
            return new PersonalInfoPage(_driver);
        }

        public PrestaShop EcommerceClick()
        {
            _driver.FindElement(_ecommerce).Click();
            return new PrestaShop(_driver);
        }
    }
}
