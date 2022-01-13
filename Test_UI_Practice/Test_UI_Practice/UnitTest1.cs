using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test_UI_Practice
{
    public class UnitTest1 : BaseTest
    {
        IWebDriver chrome;
        [Fact]
        public void TestBannerAdvert()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.clickHeaderBanner();
        }
        [Fact]
        public void TestBanner_ToContactUs()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.clickHeaderContactUs();
        }
        [Fact]
        public void TestBanner_ToSignIn()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.clickHeaderSignIn();
        }
        [Fact]
        public void Test_Logo()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.clickLogo();
        }
        [Fact]
        public void Test_AddSearch()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.searchAndAddString();
        }
        [Fact]
        public void Test_SendSearch()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.searchAndAddString();
        }
        [Fact]
        public void Test_SearchMagnifier()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.clickSearchMagnifier();
        }
        [Fact]
        public void Test_DropDownWomenCheck()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header header = new HomePage(chrome);
            header.dropDownWomen();
        }
        [Fact]
        public void Test_DropDownWomenClick()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header header = new HomePage(chrome);
            header.dropDownWomenClick();
        }
        [Fact]
        public void Test_DropDownWomenTops()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header header = new HomePage(chrome);
            header.dropDownWomenChoice_Tops();
        }
        [Fact]
        public void Test_DropDownWomenTshorts()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header header = new HomePage(chrome);
            header.dropDownWomenChoice_Tshirts();
        }
        [Fact]
        public void Test_DropDownWomenBlouses()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header header = new HomePage(chrome);
            header.dropDownWomenChoice_Blouses();
        }
        [Fact]
        public void Test_DropDownWomenDresses()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header header = new HomePage(chrome);
            header.dropDownWomenChoice_Dresses();
        }
        [Fact]
        public void Test_DropDownWomenCasualDresses()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header header = new HomePage(chrome);
            header.dropDownWomenChoice_CasualDresses();
        }
        [Fact]
        public void Test_DropDownWomenEveningDresses()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header header = new HomePage(chrome);
            header.dropDownWomenChoice_EveningDresses();
        }
        [Fact]
        public void Test_DropDownWomenSummerDresses()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header header = new HomePage(chrome);
            header.dropDownWomenChoice_SummerDresses();
        }
        [Fact]
        public void Test_DropDownDress()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header header = new HomePage(chrome);
            header.dropDownDresses();
        }
        [Fact]
        public void Test_DropDownDressClick()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header header = new HomePage(chrome);
            header.dropDownDressesClick();
        }
        [Fact]
        public void Test_DropDownDressCasualDresses()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header header = new HomePage(chrome);
            header.dropDownCasualDresses();
        }
        [Fact]
        public void Test_DropDownDressEveningDresses()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header header = new HomePage(chrome);
            header.dropDownEveningDresses();
        }
        [Fact]
        public void Test_DropDownDressSummerDresses()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            Header header = new HomePage(chrome);
            header.dropDownSummerDresses();
        }
    }
}
