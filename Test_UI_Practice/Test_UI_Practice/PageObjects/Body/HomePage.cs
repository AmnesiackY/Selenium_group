using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Test_UI_Practice.tests
{
    public class HomePage 
    {
        protected IWebDriver driver;
        
        private readonly By _firstSlide = By.CssSelector("img[alt='sample-1']");
        private readonly By _secondSlide = By.CssSelector("img[alt='sample-2']");
        private readonly By _thirdSlide = By.CssSelector("img[alt='sample-3']");
        private readonly By _topBanner = By.ClassName("htmlcontent-item-1 col-xs-4"); 
        private readonly By _bottomBanner = By.ClassName("htmlcontent-item-2 col-xs-4");
        private readonly By _buttonPrev = By.ClassName("bx-prev");
        private readonly By _buttonNext = By.ClassName("bx-next");

        private readonly By _buttonPopular = By.LinkText("active");

        private readonly By _firstProduct = By.CssSelector("img[alt='Faded Short Sleeve T-shirts']");
        private readonly By _secondProduct = By.CssSelector("img[alt='Blouse']");
        private readonly By _thirdPopular = By.XPath("//li[3]/div/div/div/a/img");
        private readonly By _fourthPopular = By.CssSelector("//li[4]/div/div/div/a/img");
        private readonly By _fifthPopular = By.CssSelector("img[alt='//li[5]/div/div/div/a/img']");
        private readonly By _sixthPopular = By.CssSelector("img[alt='//li[6]/div/div/div/a/img']");
        private readonly By _seventhPopular = By.CssSelector("img[alt='Printed Chiffon Dress']");

        private readonly By _buttonBestSellers = By.ClassName("blockbestsellers");                      //INTERNAL BRO(?)

        private readonly By _bottomBanner1 = By.ClassName("htmlcontent-item-1 col-xs-4");
        private readonly By _bottomBanner2 = By.ClassName("htmlcontent-item-2 col-xs-4");
        private readonly By _bottomBanner3 = By.ClassName("htmlcontent-item-3 col-xs-4");
        private readonly By _bottomBanner4 = By.ClassName("htmlcontent-item-4 col-xs-4");
        private readonly By _bottomBanner5 = By.ClassName("htmlcontent-item-5 col-xs-4");

        private readonly By _buttonSeleniumFrameWork = By.ClassName("btn btn-default");


    }
}
