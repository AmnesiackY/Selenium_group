using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
//Делал Ярык
namespace Test_UI_Practice.tests
{
    public class HomePage
    {
        protected IWebDriver _driver;
        //банеры под header'ом
        private readonly By _firstSlide = By.CssSelector("img[alt='sample-1']");
        private readonly By _secondSlide = By.CssSelector("img[alt='sample-2']");
        private readonly By _thirdSlide = By.CssSelector("img[alt='sample-3']");
        private readonly By _topBanner = By.ClassName("htmlcontent-item-1 col-xs-4");
        private readonly By _bottomBanner = By.ClassName("htmlcontent-item-2 col-xs-4");
        private readonly By _buttonPrev = By.ClassName("bx-prev");
        private readonly By _buttonNext = By.ClassName("bx-next");
        //фильтры продуктов
        private readonly By _buttonPopular = By.LinkText("active");
        private readonly By _buttonBestSellers = By.ClassName("blockbestsellers");

        private readonly By _fadedTshirt = By.CssSelector("img[alt='Faded Short Sleeve T-shirts']");
        private readonly By _blouse = By.CssSelector("img[alt='Blouse']");
        private readonly By _printedDressOne = By.XPath("//li[3]/div/div/div/a/img");
        private readonly By _printedDressTwo = By.CssSelector("//li[4]/div/div/div/a/img");
        private readonly By _printedSummerDressOne = By.CssSelector("img[alt='//li[5]/div/div/div/a/img']");
        private readonly By _printedSummerDressTwo = By.CssSelector("img[alt='//li[6]/div/div/div/a/img']");
        private readonly By _printedChiffonDress = By.CssSelector("img[alt='Printed Chiffon Dress']");
        //кнопки товара
        private readonly By _size = By.Id("group_1");      
        private readonly By _quantity = By.Id("quantity_wanted");
        private readonly By _plus = By.ClassName("btn btn-default button-plus product_quantity_up");
        private readonly By _minus = By.ClassName("btn btn-default button-minus product_quantity_down");
        private readonly By _quickView = By.XPath("//span[contains(.,'Quick view')]");
        private readonly By _addToCart = By.XPath("//span[contains(.,'Add to cart')]");
        private readonly By _more = By.XPath("//span[contains(.,'More')]");
        //банеры перед footer'ом
        private readonly By _bottomBanner1 = By.ClassName("htmlcontent-item-1 col-xs-4");
        private readonly By _bottomBanner2 = By.ClassName("htmlcontent-item-2 col-xs-4");
        private readonly By _bottomBanner3 = By.ClassName("htmlcontent-item-3 col-xs-4");
        private readonly By _bottomBanner4 = By.ClassName("htmlcontent-item-4 col-xs-4");
        private readonly By _bottomBanner5 = By.ClassName("htmlcontent-item-5 col-xs-4");
        //кнопка про SeleniumFramework
        private readonly By _buttonSeleniumFrameWork = By.ClassName("btn btn-default");
        


        //методы на проклик баннеров (header)
        public HomePage ClickFirstBannerSlider()
        {
            _driver.FindElement(_firstSlide).Click();
            return new PrestaShop(_driver);
        }
        public HomePage ClickSecondBannerSlider()
        {
            _driver.FindElement(_secondSlide).Click();
            return new PrestaShop(_driver);
        }
        public HomePage ClickThirdBannerSlider()
        {
            _driver.FindElement(_thirdSlide).Click();
            return new PrestaShop(_driver);
        }
        public HomePage ClickTopBanner()
        {
            _driver.FindElement(_topBanner).Click();
            return new PrestaShop(_driver);
        }
        public HomePage ClickBotomBanner()
        {
            _driver.FindElement(_bottomBanner).Click();
            return new PrestaShop(_driver);
        }
        public HomePage ClickPrevButton()
        {
            _driver.FindElement(_buttonPrev).Click();
            return this;
        }
        public HomePage ClickNextButton()
        {
            _driver.FindElement(_buttonNext).Click();
            return this;
        }

        //Работа с фильтрами.
        public HomePage ClickButtonPopular()
        {
            _driver.FindElement(_buttonPopular).Click();
            return this;
        }
        public HomePage ClickButtonBestSellers()
        {
            _driver.FindElement(_buttonBestSellers).Click();
            return this;
        }
        public FadedTshirt ClickFadedTshirtProduct()
        {
            _driver.FindElement(_fadedTshirt).Click();
            return new FadedTshirt(_driver);
        }
        public HomePage ClickQuickViewFadedTshirtProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_fadedTshirt);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }
        public HomePage FadedTshirtQuickViewQuantity()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_fadedTshirt);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement plus = _driver.FindElement(_plus);
            plus.Click();
            IWebElement minus = _driver.FindElement(_minus);
            minus.Click();
            IWebElement quantity = _driver.FindElement(_quantity);
            quantity.SendKeys("100");
            quantity.SendKeys(Keys.Enter);
            return this;
        }
        public HomePage FadedTshirtQuickViewSize()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_fadedTshirt);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement size = _driver.FindElement(_size);
            size.Click();
            size.SendKeys(Keys.ArrowDown);
            size.SendKeys(Keys.Enter);
            return this;
        }
        public HomePage FadedTshirtQuickViewColor()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_fadedTshirt);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement color1 = _driver.FindElement(By.Name("Blue"));
            color1.Click();
            IWebElement color2 = _driver.FindElement(By.Name("Orange"));
            color2.Click();
            return this;
        }

        public HomePage ClickAddToCartFadedTshirtProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_fadedTshirt);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_addToCart).Click();
            return this;
        }
        public HomePage ClickMoreFadedTshirtProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_fadedTshirt);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_more).Click();
            return this;
        }
        public Blouse ClickBlouseProduct()
        {
            _driver.FindElement(_blouse).Click();
            return new Blouse(_driver);
        }
        public HomePage ClickQuickViewBlouseProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_blouse);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }

        public HomePage BlouseQuickViewQuantity()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_blouse);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement plus = _driver.FindElement(_plus);
            plus.Click();
            IWebElement minus = _driver.FindElement(_minus);
            minus.Click();
            IWebElement quantity = _driver.FindElement(_quantity);
            quantity.SendKeys("100");
            quantity.SendKeys(Keys.Enter);
            return this;
        }
        public HomePage BlouseQuickViewSize()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_blouse);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement size = _driver.FindElement(_size);
            size.Click();
            size.SendKeys(Keys.ArrowDown);
            size.SendKeys(Keys.Enter);
            return this;
        }
        public HomePage BlouseQuickViewColor()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_blouse);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement color1 = _driver.FindElement(By.Name("Black"));
            color1.Click();
            IWebElement color2 = _driver.FindElement(By.Name("White"));
            color2.Click();
            return this;
        }
        public HomePage ClickAddToCartBlouseProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_blouse);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_addToCart).Click();
            return this;
        }
        public HomePage ClickMoreBlouseProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_blouse);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_more).Click();
            return this;
        }
        public PrintedDressOne ClickPrintedDressOneProduct()
        {
            _driver.FindElement(_printedDressOne).Click();
            return new PrintedDressOne(_driver);
        }
        public HomePage ClickQuickViewPrintedDressOneProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedDressOne);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }
        public HomePage PrintedDressOneQuickViewQuantity()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_printedDressOne);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement plus = _driver.FindElement(_plus);
            plus.Click();
            IWebElement minus = _driver.FindElement(_minus);
            minus.Click();
            IWebElement quantity = _driver.FindElement(_quantity);
            quantity.SendKeys("100");
            quantity.SendKeys(Keys.Enter);
            return this;
        }
        public HomePage PrintedDressOneQuickViewSize()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_printedDressOne);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement size = _driver.FindElement(_size);
            size.Click();
            size.SendKeys(Keys.ArrowDown);
            size.SendKeys(Keys.Enter);
            return this;
        }
        public HomePage PrintedDressOneQuickViewColor()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_printedDressOne);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement color1 = _driver.FindElement(By.Name("Orange"));
            color1.Click();
            return this;
        }

        public HomePage ClickAddToCartPrintedDressOneProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedDressOne);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_addToCart).Click();
            return this;
        }
        public HomePage ClickMorePrintedDressOneProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedDressOne);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_more).Click();
            return this;
        }
        public PrintedDressTwo ClickPrintedDressTwoProduct()
        {
            _driver.FindElement(_printedDressTwo).Click();
            return new PrintedDressTwo(_driver);
        }
        public HomePage ClickQuickViewPrintedDressTwoProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedDressTwo);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }
        public HomePage PrintedDressTwoQuickViewQuantity()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_printedDressTwo);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement plus = _driver.FindElement(_plus);
            plus.Click();
            IWebElement minus = _driver.FindElement(_minus);
            minus.Click();
            IWebElement quantity = _driver.FindElement(_quantity);
            quantity.SendKeys("100");
            quantity.SendKeys(Keys.Enter);
            return this;
        }
        public HomePage PrintedDressTwoQuickViewSize()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_printedDressTwo);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement size = _driver.FindElement(_size);
            size.Click();
            size.SendKeys(Keys.ArrowDown);
            size.SendKeys(Keys.Enter);
            return this;
        }
        public HomePage PrintedDressTwoQuickViewColor()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_printedDressTwo);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement color1 = _driver.FindElement(By.Name("Pink"));
            color1.Click();
            IWebElement color2 = _driver.FindElement(By.Name("Beige"));
            color2.Click();
            return this;
        }
        public HomePage ClickAddToCartPrintedDressTwoProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedDressTwo);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_addToCart).Click();
            return this;
        }
        public HomePage ClickMorePrintedDressTwoProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedDressTwo);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_more).Click();
            return this;
        }
        public PrintedSummerDressOne ClickPrintedSummerDressOneProduct()
        {
            _driver.FindElement(_printedSummerDressOne).Click();
            return new PrintedSummerDressOne(_driver);
        }
        public HomePage ClickQuickViewPrintedSummerDressOneProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedSummerDressOne);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }
        public HomePage PrintedSummerDressOneQuickViewQuantity()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_printedSummerDressOne);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement plus = _driver.FindElement(_plus);
            plus.Click();
            IWebElement minus = _driver.FindElement(_minus);
            minus.Click();
            IWebElement quantity = _driver.FindElement(_quantity);
            quantity.SendKeys("100");
            quantity.SendKeys(Keys.Enter);
            return this;
        }
        public HomePage PrintedSummerDressOneQuickViewSize()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_printedSummerDressOne);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement size = _driver.FindElement(_size);
            size.Click();
            size.SendKeys(Keys.ArrowDown);
            size.SendKeys(Keys.Enter);
            return this;
        }
        public HomePage PrintedSummerDressOneQuickViewColor()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_printedSummerDressOne);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement color1 = _driver.FindElement(By.Name("Orange"));
            color1.Click();
            IWebElement color2 = _driver.FindElement(By.Name("Blue"));
            color2.Click();
            IWebElement color3 = _driver.FindElement(By.Name("Yellow"));
            color3.Click();
            IWebElement color4 = _driver.FindElement(By.Name("Black"));
            color4.Click();
            return this;
        }
        public HomePage ClickAddToCartPrintedSummerDressOneProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedSummerDressOne);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_addToCart).Click();
            return this;
        }
        public HomePage ClickMorePrintedSummerDressOneProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedSummerDressOne);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_more).Click();
            return this;
        }
        public PrintedSummerDressTwo ClickPrintedSummerDressTwoProduct()
        {
            _driver.FindElement(_printedSummerDressTwo).Click();
            return new PrintedSummerDressTwo(_driver);
        }
        public HomePage ClickQuickViewPrintedSummerDressTwoProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedSummerDressTwo);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }
        public HomePage PrintedSummerDressTwoQuickViewQuantity()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_printedSummerDressTwo);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement plus = _driver.FindElement(_plus);
            plus.Click();
            IWebElement minus = _driver.FindElement(_minus);
            minus.Click();
            IWebElement quantity = _driver.FindElement(_quantity);
            quantity.SendKeys("100");
            quantity.SendKeys(Keys.Enter);
            return this;
        }
        public HomePage PrintedSummerDressTwoQuickViewSize()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_printedSummerDressTwo);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement size = _driver.FindElement(_size);
            size.Click();
            size.SendKeys(Keys.ArrowDown);
            size.SendKeys(Keys.Enter);
            return this;
        }
        public HomePage PrintedSummerDressTwoQuickViewColor()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_printedSummerDressTwo);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement color1 = _driver.FindElement(By.Name("Yellow"));
            color1.Click();
            IWebElement color2 = _driver.FindElement(By.Name("White"));
            color2.Click(); 
            return this;
        }
        public HomePage ClickAddToCartPrintedSummerDressTwoProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedSummerDressTwo);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_addToCart).Click();
            return this;
        }
        public HomePage ClickMorePrintedSummerDressTwoProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedSummerDressTwo);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_more).Click();
            return this;
        }
        public PrintedChiffonDress ClickPrintedChiffonDressProduct()
        {
            _driver.FindElement(_printedChiffonDress).Click();
            return new PrintedChiffonDress(_driver);
        }
        public HomePage ClickQuickViewPrintedChiffonDressProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedChiffonDress);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }
        public HomePage PrintedChiffonDressQuickViewQuantity()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_printedChiffonDress);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement plus = _driver.FindElement(_plus);
            plus.Click();
            IWebElement minus = _driver.FindElement(_minus);
            minus.Click();
            IWebElement quantity = _driver.FindElement(_quantity);
            quantity.SendKeys("100");
            quantity.SendKeys(Keys.Enter);
            return this;
        }
        public HomePage PrintedChiffonDressQuickViewSize()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_printedChiffonDress);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement size = _driver.FindElement(_size);
            size.Click();
            size.SendKeys(Keys.ArrowDown);
            size.SendKeys(Keys.Enter);
            return this;
        }
        public HomePage PrintedChiffonDressQuickViewColor()
        {
            Actions act = new Actions(_driver);
            IWebElement img = _driver.FindElement(_printedChiffonDress);
            act.MoveToElement(img).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement color1 = _driver.FindElement(By.Name("Yellow"));
            color1.Click();
            IWebElement color2 = _driver.FindElement(By.Name("White"));
            color2.Click();
            return this;
        }
        public HomePage ClickAddToCartPrintedChiffonDressProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedChiffonDress);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_addToCart).Click();
            return this;
        }
        public HomePage ClickMorePrintedChiffonDressProduct()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedChiffonDress);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_more).Click();
            return this;
        }
        public FadedTshirt ClickFadedTshirtProductBestseller()
        {
            _driver.FindElement(_buttonBestSellers).Click();
            _driver.FindElement(_fadedTshirt).Click();
            return new FadedTshirt(_driver);
        }

        public HomePage ClickQuickViewFadedTshirtProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_fadedTshirt);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }
        public HomePage ClickAddToCartFadedTshirtProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_fadedTshirt);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_addToCart).Click();
            return this;
        }
        public HomePage ClickMoreFadedTshirtProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_fadedTshirt);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_more).Click();
            return this;
        }
        public Blouse ClickBlouseProductBestseller()
        {
            _driver.FindElement(_buttonBestSellers).Click();
            _driver.FindElement(_blouse).Click();
            return new Blouse(_driver);
        }
        public HomePage ClickQuickViewBlouseProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_blouse);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }
        public HomePage ClickAddToCartBlouseProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_blouse);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_addToCart).Click();
            return this;
        }
        public HomePage ClickMoreBlouseProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_blouse);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_more).Click();
            return this;
        }
        public PrintedDressOne ClickPrintedDressOneProductBestseller()
        {
            _driver.FindElement(_buttonBestSellers).Click();
            _driver.FindElement(_printedDressOne).Click();
            return new PrintedDressOne(_driver);
        }
        public HomePage ClickQuickViewPrintedDressOneProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedDressOne);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }
        public HomePage ClickAddToCartPrintedDressOneProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedDressOne);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_addToCart).Click();
            return this;
        }
        public HomePage ClickMorePrintedDressOneProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedDressOne);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_more).Click();
            return this;
        }
        public PrintedDressTwo ClickPrintedDressTwoProductBestseller()
        {
            _driver.FindElement(_buttonBestSellers).Click();
            _driver.FindElement(_printedDressTwo).Click();
            return new PrintedDressTwo(_driver);
        }

        public HomePage ClickQuickViewPrintedDressTwoProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedDressTwo);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }
        public HomePage ClickAddToCartPrintedDressTwoProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedDressTwo);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_addToCart).Click();
            return this;
        }
        public HomePage ClickMorePrintedDressTwoProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedDressTwo);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_more).Click();
            return this;
        }
        public PrintedSummerDressOne ClickPrintedSummerDressOneProductBestseller()
        {
            _driver.FindElement(_buttonBestSellers).Click();
            _driver.FindElement(_printedSummerDressOne).Click();
            return new PrintedSummerDressOne(_driver);
        }
        public HomePage ClickQuickViewPrintedSummerDressOneProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedSummerDressOne);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }
        public HomePage ClickAddToCartPrintedSummerDressOneProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedSummerDressOne);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_addToCart).Click();
            return this;
        }
        public HomePage ClickMorePrintedSummerDressOneProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedSummerDressOne);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_more).Click();
            return this;
        }
        public PrintedSummerDressTwo ClickPrintedSummerDressTwoProductBestseller()
        {
            _driver.FindElement(_buttonBestSellers).Click();
            _driver.FindElement(_printedSummerDressTwo).Click();
            return new PrintedSummerDressTwo(_driver);
        }
        public HomePage ClickQuickViewPrintedSummerDressTwoProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedSummerDressTwo);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }
        public HomePage ClickAddToCartPrintedSummerDressTwoProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedSummerDressTwo);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_addToCart).Click();
            return this;
        }
        public HomePage ClickMorePrintedSummerDressTwoProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedSummerDressTwo);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_more).Click();
            return this;
        }
        public PrintedChiffonDress ClickPrintedChiffonDressProductBestseller()
        {
            _driver.FindElement(_buttonBestSellers).Click();
            _driver.FindElement(_printedChiffonDress).Click();
            return new PrintedChiffonDress(_driver);
        }
        public HomePage ClickQuickViewPrintedChiffonDressProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedChiffonDress);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }
        public HomePage ClickAddToCartPrintedChiffonDressProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedChiffonDress);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_addToCart).Click();
            return this;
        }
        public HomePage ClickMorePrintedChiffonDressProductBestseller()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_printedChiffonDress);
            act.MoveToElement(elem).Perform();
            _driver.FindElement(_more).Click();
            return this;
        }

        //методы на проклик баннеров (footer)
        public PrestaShop clickBottomBanner1()
        {
            _driver.FindElement(_bottomBanner1).Click();
            return new PrestaShop(_driver);
        }
        public PrestaShop clickBottomBanner2()
        {
            _driver.FindElement(_bottomBanner2).Click();
            return new PrestaShop(_driver);
        }
        public PrestaShop clickBottomBanner3()
        {
            _driver.FindElement(_bottomBanner3).Click();
            return new PrestaShop(_driver);
        }
        public PrestaShop clickBottomBanner4()
        {
            _driver.FindElement(_bottomBanner4).Click();
            return new PrestaShop(_driver);
        }
        public PrestaShop clickBottomBanner5()
        {
            _driver.FindElement(_bottomBanner5).Click();
            return new PrestaShop(_driver);
        }
        public PrestaShop clickSeleniumFrameworkButton()
        {
            _driver.FindElement(_buttonSeleniumFrameWork).Click();
            return new PrestaShop(_driver);
        }
    }
}
