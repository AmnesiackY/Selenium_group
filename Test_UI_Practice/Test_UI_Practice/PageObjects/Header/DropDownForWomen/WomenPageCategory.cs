using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
//Создал Ярык, делал Димас
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
            IWebElement minPrice =  _driver.FindElement(_priceRangeMin);
            IWebElement maxPrice = _driver.FindElement(_priceRangeMax);
            action.DragAndDrop(minPrice, maxPrice).Perform();
            return this;
        }
    }
}
