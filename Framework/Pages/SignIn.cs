using Framework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    public class SignIn
    {
        [FindsBy(How = How.CssSelector, Using = "#ap_email")]
        private IWebElement _emailInput;

        [FindsBy(How = How.CssSelector, Using = "#ap_password")]
        private IWebElement _passwordInput;

        [FindsBy(How = How.CssSelector, Using = "#signInSubmit")]
        private IWebElement _submitButton;

        [FindsBy(How = How.CssSelector, Using = "#auth-email-missing-alert")]
        private IWebElement _errorMessageMissingEmail;

        [FindsBy(How = How.CssSelector, Using = "#auth-password-missing-alert")]
        private IWebElement _errorMessageMissingPassword;

        [FindsBy(How = How.CssSelector, Using = "#auth-error-message-box")]
        private IWebElement _errorMessageWrongInput;

        [FindsBy(How = How.CssSelector, Using = "#auth-warning-message-box")]
        private IWebElement _authenticationWarningMessage;

        [FindsBy(How = How.CssSelector, Using = "#nav-link-yourAccount .nav-line-1")]
        private IWebElement _userName;

        private string SignInUrl => "https://www.amazon.co.uk/ap/signin?_encoding=UTF8&openid.assoc_handle=gbflex&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.mode=checkid_setup&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&openid.ns.pape=http%3A%2F%2Fspecs.openid.net%2Fextensions%2Fpape%2F1.0&openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.co.uk%2Fgp%2Fhelp%2Fcustomer%2Fdisplay.html%3FnodeId%3D201813210%26ref_%3Dnav_signin";


        public void NavigateToSigninPage()
        {
            Browser.NavigateTo(SignInUrl);
        }

        public void EnterEmailAddress(string email)
        {
            _emailInput.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            _passwordInput.SendKeys(password);
        }

        public void ClickSubmit()
        {
            _submitButton.Click();
        }

        public bool IsErrorMessageForMissingEmailDisplayed()
        {
            return _errorMessageMissingEmail.IsVisible();
        }

        public bool IsErrorMessageForWrongInputDisplayed()
        {
            return _errorMessageWrongInput.IsVisible() || _authenticationWarningMessage.IsVisible();
        }

        public bool IsErrorMessageForEmptyPasswordDisplayed()
        {
            return _errorMessageMissingPassword.IsVisible();
        }

        public bool IsUserRedirectedToHomePage()
        {
            return Browser.Driver.Url.Contains("ref_=nav_signin");
        }

        public string GetUserName()
        {
            return _userName.Text;
        }

        public bool IsThereAuthenticationWarningMessageDisplayed()
        {
            return _authenticationWarningMessage.IsVisible();
        }

    }
}