using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Test_UI_Practice.tests
{
    public class HomePage 
    {
        protected IWebDriver _driver;
        
        private readonly By _firstSlide = By.CssSelector("img[alt='sample-1']");
        private readonly By _secondSlide = By.CssSelector("img[alt='sample-2']");
        private readonly By _thirdSlide = By.CssSelector("img[alt='sample-3']");
        private readonly By _topBanner = By.ClassName("htmlcontent-item-1 col-xs-4"); 
        private readonly By _bottomBanner = By.ClassName("htmlcontent-item-2 col-xs-4");
        private readonly By _buttonPrev = By.ClassName("bx-prev");
        private readonly By _buttonNext = By.ClassName("bx-next");

        private readonly By _buttonPopular = By.LinkText("active");

        private readonly By _fadedTshirt = By.CssSelector("img[alt='Faded Short Sleeve T-shirts']");
        private readonly By _blouse = By.CssSelector("img[alt='Blouse']");
        private readonly By _printedDressOne = By.XPath("//li[3]/div/div/div/a/img");
        private readonly By _printedDressTwo = By.CssSelector("//li[4]/div/div/div/a/img");
        private readonly By _printedSummerDressOne = By.CssSelector("img[alt='//li[5]/div/div/div/a/img']");
        private readonly By _printedSummerDressTwo = By.CssSelector("img[alt='//li[6]/div/div/div/a/img']");
        private readonly By _printedChiffonDress = By.CssSelector("img[alt='Printed Chiffon Dress']");

        private readonly By _buttonBestSellers = By.ClassName("blockbestsellers");//INTERNAL BRO(?)

        private readonly By _bottomBanner1 = By.ClassName("htmlcontent-item-1 col-xs-4");
        private readonly By _bottomBanner2 = By.ClassName("htmlcontent-item-2 col-xs-4");
        private readonly By _bottomBanner3 = By.ClassName("htmlcontent-item-3 col-xs-4");
        private readonly By _bottomBanner4 = By.ClassName("htmlcontent-item-4 col-xs-4");
        private readonly By _bottomBanner5 = By.ClassName("htmlcontent-item-5 col-xs-4");

        private readonly By _buttonSeleniumFrameWork = By.ClassName("btn btn-default");

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
        public Blouse ClickBlouseProduct()
        {
            _driver.FindElement(_blouse).Click();
            return new Blouse(_driver);
        }
        public PrintedDressOne ClickPrintedDressOneProduct()
        {
            _driver.FindElement(_printedDressOne).Click();
            return new PrintedDressOne(_driver);
        }
        public PrintedDressTwo ClickPrintedDressTwoProduct()
        {
            _driver.FindElement(_printedDressTwo).Click();
            return new PrintedDressTwo(_driver);
        }
        public PrintedSummerDressOne ClickPrintedSummerDressOneProduct()
        {
            _driver.FindElement(_printedSummerDressOne).Click();
            return new PrintedSummerDressOne(_driver);
        }
        public PrintedSummerDressTwo ClickPrintedSummerDressTwoProduct()
        {
            _driver.FindElement(_printedSummerDressTwo).Click();
            return new PrintedSummerDressTwo(_driver);
        }
        public PrintedChiffonDress ClickPrintedChiffonDressProduct()
        {
            _driver.FindElement(_printedChiffonDress).Click();
            return new PrintedChiffonDress(_driver);
        }
        public FadedTshirt ClickFadedTshirtProductBestseller()
        {
            _driver.FindElement(_buttonBestSellers).Click();
            _driver.FindElement(_fadedTshirt).Click();
            return new FadedTshirt(_driver);
        }
        public Blouse ClickBlouseProductBestseller()
        {
            _driver.FindElement(_buttonBestSellers).Click();
            _driver.FindElement(_blouse).Click();
            return new Blouse(_driver);
        }
        public PrintedDressOne ClickPrintedDressOneProductBestseller()
        {
            _driver.FindElement(_buttonBestSellers).Click();
            _driver.FindElement(_printedDressOne).Click();
            return new PrintedDressOne(_driver);
        }
        public PrintedDressTwo ClickPrintedDressTwoProductBestseller()
        {
            _driver.FindElement(_buttonBestSellers).Click();
            _driver.FindElement(_printedDressTwo).Click();
            return new PrintedDressTwo(_driver);
        }
        public PrintedSummerDressOne ClickPrintedSummerDressOneProductBestseller()
        {
            _driver.FindElement(_buttonBestSellers).Click();
            _driver.FindElement(_printedSummerDressOne).Click();
            return new PrintedSummerDressOne(_driver);
        }
        public PrintedSummerDressTwo ClickPrintedSummerDressTwoProductBestseller()
        {
            _driver.FindElement(_buttonBestSellers).Click();
            _driver.FindElement(_printedSummerDressTwo).Click();
            return new PrintedSummerDressTwo(_driver);
        }
        public PrintedChiffonDress ClickPrintedChiffonDressProductBestseller()
        {
            _driver.FindElement(_buttonBestSellers).Click();
            _driver.FindElement(_printedChiffonDress).Click();
            return new PrintedChiffonDress(_driver);
        }

    }
}
