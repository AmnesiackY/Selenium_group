using OpenQA.Selenium;
//Создал Ярык, делал Димас
namespace Test_UI_Practice.tests
{
    public class SignIn : Header
    {
        public SignIn(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _emailCreate = By.Id("email_create");
        private readonly By _createButton = By.XPath("//div[3]/button/span");
        private readonly By _emailLogin = By.Id("email");
        private readonly By _passwordLogin = By.Id("passwd");
        private readonly By _forgotPassword = By.LinkText("Forgot your password?");
        private readonly By _loginButton = By.XPath("//p[2]/button/span");

        public SignIn EmailEnter(string email)
        {
            _driver.FindElement(_emailCreate).SendKeys(email);
            return this;
        }

        public SignIn EmailLoginEnter(string email)
        {
            _driver.FindElement(_emailLogin).SendKeys(email);
            return this;
        }

        public SignIn PasswordLoginEnter(string password)
        {
            _driver.FindElement(_passwordLogin).SendKeys(password);
            return this;
        }

        public ForgotPasswordPage ForgotPasswordClick()
        {
            _driver.FindElement(_forgotPassword).Click();
            return new ForgotPasswordPage(_driver);
        }

        public RegistrationPage RegistrationClick()
        {
            _driver.FindElement(_createButton).Click();
            return new RegistrationPage(_driver);
        }

        public Authorization AuthorizationClick()
        {
            _driver.FindElement(_loginButton).Click();
            return new Authorization(_driver);
        }
    }
}
