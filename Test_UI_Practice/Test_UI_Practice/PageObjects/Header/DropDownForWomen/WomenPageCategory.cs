using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
//Делали Ярык и Димас
namespace Test_UI_Practice.tests
{
    public class WomenPageCategory : Header
    {
        public WomenPageCategory(IWebDriver driver)
        {
            _driver = driver;
        }


        private readonly By _tops = By.LinkText("Tops (2)");
        private readonly By _dressess = By.LinkText("layered_category_8");
        private readonly By _sizeS = By.Id("layered_id_attribute_group_1");
        private readonly By _sizeM = By.Id("layered_id_attribute_group_2");
        private readonly By _sizeL = By.Id("layered_id_attribute_group_3");
        private readonly By _colorBeige = By.Id("layered_id_attribute_group_7");
        private readonly By _colorWhite = By.Id("layered_id_attribute_group_8");
        private readonly By _colorBlack = By.Id("layered_id_attribute_group_11");
        private readonly By _colorOrange = By.Id("layered_id_attribute_group_13");
        private readonly By _colorBlue = By.Id("layered_id_attribute_group_14");
        private readonly By _colorYellow = By.Id("layered_id_attribute_group_16");
        private readonly By _colorGreen = By.Id("layered_id_attribute_group_15");
        private readonly By _colorPink = By.Id("layered_id_attribute_group_24");
        private readonly By _cotton = By.Id("layered_id_feature_5");
        private readonly By _polyester = By.Id("layered_id_feature_1");
        private readonly By _viscose = By.Id("layered_id_feature_3");
        private readonly By _casual = By.Id("layered_id_feature_11");
        private readonly By _dressy = By.Id("layered_id_feature_16");
        private readonly By _girly = By.Id("layered_id_feature_13");
        private readonly By _colorfulDress = By.Id("layered_id_feature_18");
        private readonly By _maxiDress = By.Id("layered_id_feature_21");
        private readonly By _midiDress = By.Id("layered_id_feature_20");
        private readonly By _shortDress = By.Id("layered_id_feature_19");
        private readonly By _shortSleeve = By.Id("layered_id_feature_17");
        private readonly By _inStock = By.Id("layered_quantity_1");
        private readonly By _fashionManufacturer = By.Id("layered_manufacturer_1");
        private readonly By _new = By.Id("layered_condition_new");
        private readonly By _priceRangeMin = By.XPath("//ul/div/div/a");
        private readonly By _priceRangeMax = By.CssSelector(".ui-state-focus");

        //фильтры блока Women

        private readonly By _topsWomenPage = By.XPath("(//a[contains(text(),'Tops')])[2]");
        private readonly By _buttonOpenTops = By.XPath("//div[@id='categories_block_left']/div/ul/li/span");
        private readonly By _tshirtsWomenPage = By.XPath("(//a[contains(text(),'T-shirts')])[3]");
        private readonly By _blousesWomenPage = By.XPath("(//a[contains(text(),'Blouses')])[2]");

        private readonly By _dressesWomenPage = By.XPath("(//a[contains(text(),'Dresses')])[9]");
        private readonly By _buttonOpenDresses = By.XPath("//div[@id='categories_block_left']/div/ul/li[2]/span");
        private readonly By _casualDressWomenPage = By.XPath("(//a[contains(text(),'Casual Dresses')])[3]");
        private readonly By _eveningDressWomenPage = By.XPath("(//a[contains(text(),'Evening Dresses')])[3]");
        private readonly By _summerDressWomenPage = By.XPath("(//a[contains(text(),'Summer Dresses')])[3]");
        //блок Information
        private readonly By _informationButton = By.XPath("//a[contains(text(),'Information')]");

        private readonly By _deliveryInfo = By.LinkText("Delivery");
        private readonly By _legalNotice = By.LinkText("Legal Notice");
        private readonly By _termsConditionsOfUse = By.LinkText("Terms and conditions of use");
        private readonly By _aboutUs = By.LinkText("About us");
        private readonly By _securePayment = By.LinkText("Secure payment");
        private readonly By _ourStores = By.LinkText("Our stores");
        //блок OurStories
        private readonly By _ourStoresButton = By.XPath("(//a[contains(text(),'Our stores')])[2]");

        private readonly By _ourStoresImg = By.XPath("//img[@alt='Our stores']");
        private readonly By _ourStoresFilterButton = By.XPath("//span[contains(.,'Discover our stores')]");

        //блок Specials
        private readonly By _specialsButton = By.XPath("(//a[contains(text(),'Specials')]");
        private readonly By _specialsFilterButton = By.XPath("//span[contains(.,'All specials')]");

        //блок SubCategories
        private readonly By _bannerTops = By.CssSelector("li:nth-child(1) > .subcategory-image .replace-2x");
        private readonly By _bannerDresses = By.CssSelector("li:nth-child(2) > .subcategory-image .replace-2x");

        //блок View
        private readonly By _gridView = By.XPath("//li[@id='grid']/a/i");
        private readonly By _listView = By.XPath("//li[@id='list']/a/i");

        public WomenPageCategory TopsFilterClick()
        {
            _driver.FindElement(_tops).Click();
            return this;
        }

        public WomenPageCategory DressessFilterClick()
        {
            _driver.FindElement(_dressess).Click();
            return this;
        }

        public WomenPageCategory SizeSFilterClick()
        {
            _driver.FindElement(_sizeS).Click();
            return this;
        }

        public WomenPageCategory SizeMFilterClick()
        {
            _driver.FindElement(_sizeM).Click();
            return this;
        }

        public WomenPageCategory SizeLFilterClick()
        {
            _driver.FindElement(_sizeL).Click();
            return this;
        }

        public WomenPageCategory ColorBeigeFilterClick()
        {
            _driver.FindElement(_colorBeige).Click();
            return this;
        }

        public WomenPageCategory ColorWhiteFilterClick()
        {
            _driver.FindElement(_colorWhite).Click();
            return this;
        }

        public WomenPageCategory ColorBlackFilterClick()
        {
            _driver.FindElement(_colorBlack).Click();
            return this;
        }

        public WomenPageCategory ColorOrangeFilterClick()
        {
            _driver.FindElement(_colorOrange).Click();
            return this;
        }

        public WomenPageCategory ColorBlueFilterClick()
        {
            _driver.FindElement(_colorBlue).Click();
            return this;
        }

        public WomenPageCategory ColorYellowFilterClick()
        {
            _driver.FindElement(_colorYellow).Click();
            return this;
        }

        public WomenPageCategory ColorGreenFilterClick()
        {
            _driver.FindElement(_colorGreen).Click();
            return this;
        }

        public WomenPageCategory ColorPinkFilterClick()
        {
            _driver.FindElement(_colorPink).Click();
            return this;
        }

        public WomenPageCategory CottonFilterClick()
        {
            _driver.FindElement(_cotton).Click();
            return this;
        }

        public WomenPageCategory PolyesterFilterClick()
        {
            _driver.FindElement(_polyester).Click();
            return this;
        }

        public WomenPageCategory ViscoseFilterClick()
        {
            _driver.FindElement(_viscose).Click();
            return this;
        }

        public WomenPageCategory CasualFilterClick()
        {
            _driver.FindElement(_casual).Click();
            return this;
        }
        public WomenPageCategory DressyFilterClick()
        {
            _driver.FindElement(_dressy).Click();
            return this;
        }
        public WomenPageCategory GirlyFilterClick()
        {
            _driver.FindElement(_girly).Click();
            return this;
        }

        public WomenPageCategory ColorfulDressFilterClick()
        {
            _driver.FindElement(_colorfulDress).Click();
            return this;
        }

        public WomenPageCategory MaxiDressFilterClick()
        {
            _driver.FindElement(_maxiDress).Click();
            return this;
        }

        public WomenPageCategory MidiDressFilterClick()
        {
            _driver.FindElement(_midiDress).Click();
            return this;
        }

        public WomenPageCategory ShortDressFilterClick()
        {
            _driver.FindElement(_shortDress).Click();
            return this;
        }

        public WomenPageCategory ShortSleeveFilterClick()
        {
            _driver.FindElement(_shortSleeve).Click();
            return this;
        }

        public WomenPageCategory InStockFilterClick()
        {
            _driver.FindElement(_inStock).Click();
            return this;
        }

        public WomenPageCategory FashionManufacturerFilterClick()
        {
            _driver.FindElement(_fashionManufacturer).Click();
            return this;
        }

        public WomenPageCategory NewFilterClick()
        {
            _driver.FindElement(_new).Click();
            return this;
        }

        public WomenPageCategory PriceRangeFilterClick()
        {
            Actions action = new Actions(_driver);
            IWebElement minPrice = _driver.FindElement(_priceRangeMin);
            IWebElement maxPrice = _driver.FindElement(_priceRangeMax);
            action.DragAndDrop(minPrice, maxPrice).Perform();
            return this;
        }


        public TopsCategory ClickTopWomenPage()
        {
            _driver.FindElement(_topsWomenPage).Click();
            return new TopsCategory(_driver);
        }
        public TshirtsCategory ClickTshirtWomenPage()
        {
            _driver.FindElement(_buttonOpenTops).Click();
            _driver.FindElement(_tshirtsWomenPage).Click();
            return new TshirtsCategory(_driver);
        }
        public BlousesCategory ClickBlousesWomenPage()
        {
            _driver.FindElement(_buttonOpenTops).Click();
            _driver.FindElement(_blousesWomenPage).Click();
            return new BlousesCategory(_driver);
        }
        public DressesCatagory ClickDressesWomenPage()
        {
            _driver.FindElement(_dressesWomenPage).Click();
            return new DressesCatagory(_driver);
        }
        public CasualDressesCategory ClickCasualDressesWomenPage()
        {
            _driver.FindElement(_buttonOpenDresses).Click();
            _driver.FindElement(_casualDressWomenPage).Click();
            return new CasualDressesCategory(_driver);
        }
        public EveningDressesCategory ClickEveningDressesWomenPage()
        {
            _driver.FindElement(_buttonOpenDresses).Click();
            _driver.FindElement(_eveningDressWomenPage).Click();
            return new EveningDressesCategory(_driver);
        }
        public SummerDressesCategory ClickSummerDressesWomenPage()
        {
            _driver.FindElement(_buttonOpenDresses).Click();
            _driver.FindElement(_summerDressWomenPage).Click();
            return new SummerDressesCategory(_driver);
        }
        public InformationPage ClickInformationWomenPage()
        {
            _driver.FindElement(_informationButton).Click();
            return new InformationPage(_driver);
        }
        public DeliveryPage ClickDeliveryWomenPage()
        {
            _driver.FindElement(_deliveryInfo).Click();
            return new DeliveryPage(_driver);
        }
        public LegalNoticePage ClickLegalNoticeWomenPage()
        {
            _driver.FindElement(_legalNotice).Click();
            return new LegalNoticePage(_driver);
        }
        public TermsAndConditionsPage ClickTermsConditionsWomenPage()
        {
            _driver.FindElement(_termsConditionsOfUse).Click();
            return new TermsAndConditionsPage(_driver);
        }
        public AboutUsPage ClickAboutUsWomenPage()
        {
            _driver.FindElement(_aboutUs).Click();
            return new AboutUsPage(_driver);
        }
        public SecurePaymentPage ClickSecurePaymentWomenPage()
        {
            _driver.FindElement(_securePayment).Click();
            return new SecurePaymentPage(_driver);
        }
        public OurStoresPage ClickOurStoresWomenPage()
        {
            _driver.FindElement(_ourStores).Click();
            return new OurStoresPage(_driver);
        }
        public OurStoresPage ClickOurStoresButtonWomenPage()
        {
            _driver.FindElement(_ourStoresButton).Click();
            return new OurStoresPage(_driver);
        }
        public OurStoresPage ClickOurStoresImgWomenPage()
        {
            _driver.FindElement(_ourStoresImg).Click();
            return new OurStoresPage(_driver);
        }
        public OurStoresPage ClickOurStoresFilterButtonWomenPage()
        {
            _driver.FindElement(_ourStoresFilterButton).Click();
            return new OurStoresPage(_driver);
        }
        public SpecialsPage ClickSpecialsButtonWomenPage()
        {
            _driver.FindElement(_specialsButton).Click();
            return new SpecialsPage(_driver);
        }
        public SpecialsPage ClickSpecialsFilterButtonWomenPage()
        {
            _driver.FindElement(_specialsFilterButton).Click();
            return new SpecialsPage(_driver);
        }
        public TopsCategory ClickBannerTopsWomenPage()
        {
            _driver.FindElement(_bannerTops).Click();
            return new TopsCategory(_driver);
        }
        public DressesCatagory ClickBannerDressesWomenPage()
        {
            _driver.FindElement(_bannerDresses).Click();
            return new DressesCatagory(_driver);
        }
        public WomenPageCategory ClickChangeToGridViewWomenPage()
        {
            _driver.FindElement(_gridView).Click();
            return this;
        }
        public WomenPageCategory ClickChangeToListViewWomenPage()
        {
            _driver.FindElement(_listView).Click();

            return this;
        }
    }
}
