using Framework;
using Framework.Helpers;
using Framework.Pages;
using Shouldly;
using TechTalk.SpecFlow;

namespace Tests.Steps
{
    [Binding]
    public class SignInPageSteps
    {
        [Given(@"I navigate to log in page for amazon")]
        public void GivenINavigateToLogInPageForAmazon()
        {
            Pages.SignIn.NavigateToSigninPage();
            //Browser.Initialize();
            Browser.NavigateTo("https://www.amazon.co.uk/ap/signin?_encoding=UTF8&openid.assoc_handle=gbflex&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.mode=checkid_setup&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&openid.ns.pape=http%3A%2F%2Fspecs.openid.net%2Fextensions%2Fpape%2F1.0&openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.co.uk%2Fgp%2Fhelp%2Fcustomer%2Fdisplay.html%3FnodeId%3D201813210%26ref_%3Dnav_signin");
            Sync.WaitUntilPageIsCompletelyLoaded();
        }

        [When(@"I enter (.*)  to email input")]
        public void WhenIEnterToEmailInput(string email)
        {
            Pages.SignIn.EnterEmailAddress(email);
        }

        [When(@"I enter (.*) to password input")]
        public void WhenIEnterToPasswordInput(string password)
        {
            Pages.SignIn.EnterPassword(password);
        }

        [When(@"I click submit button")]
        public void WhenIClickSubmitButton()
        {
            Pages.SignIn.ClickSubmit();
        }

        [When(@"I leave password empty")]
        public void WhenILeavePasswordEmpty()
        {
            Pages.SignIn.EnterPassword("");
        }


        [Then(@"I am redirected to home page as a logged user")]
        public void ThenIAmRedirectedToHomePageAsALoggedUser()
        {
            Sync.WaitUntilPageIsCompletelyLoaded();
            Pages.SignIn.IsUserRedirectedToHomePage().ShouldBe(true);
            Pages.SignIn.GetUserName().ShouldContain("NameTest");
        }

        [Then(@"an error message is displayed for email")]
        [Then(@"an error message is displayed for password")]
        public void ThenAnErrorMessageIsDisplayedForPassword()
        {
            Pages.SignIn.IsErrorMessageForWrongInputDisplayed().ShouldBe(true);
        }

        [Then(@"an error message is displayed for both inputs")]
        public void ThenAnErrorMessageIsDisplayedForBothInputs()
        {
            Pages.SignIn.IsErrorMessageForMissingEmailDisplayed().ShouldBe(true);
            Pages.SignIn.IsErrorMessageForEmptyPasswordDisplayed().ShouldBe(true);
        }

        [Then(@"an error message is displayed for empty password")]
        public void ThenAnErrorMessageIsDisplayedForEmptyPassword()
        {
            Pages.SignIn.IsErrorMessageForEmptyPasswordDisplayed().ShouldBe(true);
        }

        //[Then(@"an error message is displayed for authentication")]
        //public void ThenAnErrorMessageIsDisplayedForAuthentication()
        //{
        //    Pages.SignIn.IsThereAuthenticationWarningMessageDisplayed().ShouldBe(true);
        //}
    }
}
