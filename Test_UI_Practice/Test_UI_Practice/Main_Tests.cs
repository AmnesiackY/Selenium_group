using Xunit;
using OpenQA.Selenium;
//ƒелал ярык
namespace Test_UI_Practice.tests
{
    public class Main_Tests : BaseTest
    {
        IWebDriver chrome;
        [Fact]
        public void TestBannerAdvert()
        {
            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
            HomePage homePage = new HomePage();
            homePage;
        }
    }
}
//        [Fact]
//        public void TestBanner_ToContactUs()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header homePage = new HomePage(chrome);
//            homePage.ClickHeaderContactUs();
//        }
//        [Fact]
//        public void TestBanner_ToSignIn()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header homePage = new HomePage(chrome);
//            homePage.ClickHeaderSignIn();
//        }
//        [Fact]
//        public void Test_Logo()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header homePage = new HomePage(chrome);
//            homePage.ClickLogo();
//        }
//        [Fact]
//        public void Test_AddSearch()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header homePage = new HomePage(chrome);
//            homePage.SearchAndAddString();
//        }
//        [Fact]
//        public void Test_SendSearch()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header homePage = new HomePage(chrome);
//            homePage.SearchAndAddString();
//        }
//        [Fact]
//        public void Test_SearchMagnifier()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header homePage = new HomePage(chrome);
//            homePage.ClickSearchMagnifier();
//        }
//        [Fact]
//        public void Test_DropDownWomenCheck()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header header = new HomePage(chrome);
//            header.DropDownWomen();
//        }
//        [Fact]
//        public void Test_DropDownWomenClick()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header header = new HomePage(chrome);
//            header.DropDownWomenClick();
//        }
//        [Fact]
//        public void Test_DropDownWomenTops()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header header = new HomePage(chrome);
//            header.DropDownWomenChoice_Tops();
//        }
//        [Fact]
//        public void Test_DropDownWomenTshorts()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header header = new HomePage(chrome);
//            header.DropDownWomenChoice_Tshirts();
//        }
//        [Fact]
//        public void Test_DropDownWomenBlouses()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header header = new HomePage(chrome);
//            header.DropDownWomenChoice_Blouses();
//        }
//        [Fact]
//        public void Test_DropDownWomenDresses()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header header = new HomePage(chrome);
//            header.DropDownWomenChoice_Dresses();
//        }
//        [Fact]
//        public void Test_DropDownWomenCasualDresses()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header header = new HomePage(chrome);
//            header.DropDownWomenChoice_CasualDresses();
//        }
//        [Fact]
//        public void Test_DropDownWomenEveningDresses()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header header = new HomePage(chrome);
//            header.DropDownWomenChoice_EveningDresses();
//        }
//        [Fact]
//        public void Test_DropDownWomenSummerDresses()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header header = new HomePage(chrome);
//            header.DropDownWomenChoice_SummerDresses();
//        }
//        [Fact]
//        public void Test_DropDownDress()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header header = new HomePage(chrome);
//            header.DropDownDresses();
//        }
//        [Fact]
//        public void Test_DropDownDressClick()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header header = new HomePage(chrome);
//            header.DropDownDressesClick();
//        }
//        [Fact]
//        public void Test_DropDownDressCasualDresses()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header header = new HomePage(chrome);
//            header.DropDownCasualDresses();
//        }
//        [Fact]
//        public void Test_DropDownDressEveningDresses()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header header = new HomePage(chrome);
//            header.DropDownEveningDresses();
//        }
//        [Fact]
//        public void Test_DropDownDressSummerDresses()
//        {
//            chrome = StartDriverWithUrl("http://automationpractice.com/index.php");
//            Header header = new HomePage(chrome);
//            header.DropDownSummerDresses();
//        }
//    }
//}
