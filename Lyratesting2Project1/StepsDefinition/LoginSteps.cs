using System;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace Lyratesting2Project1
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            Lyratesting2Project1.Pages.HomePage.Goto();
        }
        
        [Given(@"I can login account")]
        public void GivenICanLoginAccount()
        {
            Lyratesting2Project1.Pages.HomePage.GotoLoginPage();
        }
        
        [Given(@"I am on the login page but forget password")]
        public void GivenIAmOnTheLoginPageButForgetPassword()
        {
            Lyratesting2Project1.Pages.HomePage.Goto();
            Lyratesting2Project1.Pages.HomePage.GotoLoginPage();
        }
        
        [Given(@"I click reset-password link")]
        public void GivenIClickReset_PasswordLink()
        {
            Lyratesting2Project1.Pages.LoginPage.ClickResetPsw();
        }
        
        [When(@"I can input valid username and password")]
        public void WhenICanInputValidUsernameAndPassword(Table table)
        {
            Lyratesting2Project1.Pages.LoginPage.LoginSuccess(table.Rows[0][0], table.Rows[0][1]);
        }
        
        [When(@"I can input valid username and password with clicking remember-me")]
        public void WhenICanInputValidUsernameAndPasswordWithClickingRemember_Me(Table table)
        {
            Lyratesting2Project1.Pages.LoginPage.LoginSuccessWithSelectRememberMe(table.Rows[0][0], table.Rows[0][1]);
        }
        
        [When(@"I can input invalid username and password")]
        public void WhenICanInputInvalidUsernameAndPassword(Table table)
        {
            Lyratesting2Project1.Pages.LoginPage.LoginFail(table.Rows[0][0], table.Rows[0][1]);
        }
        
        [When(@"I input ""(.*)"" email to reset password")]
        public void WhenIInputEmailToResetPassword(string p0)
        {
            Lyratesting2Project1.Pages.LoginPage.ResetPswWithEmail(p0); 
        }
        
        [Then(@"I can login success")]
        public void ThenICanLoginSuccess()
        {
            Lyratesting2Project1.Pages.HomePage.CheckAvatarSeen();
            Lyratesting2Project1.Pages.HomePage.LogOut();
        }
        
        [Then(@"I login failure")]
        public void ThenILoginFailure()
        {
            Lyratesting2Project1.Pages.LoginPage.CheckLoginErrorMsg();
        }
        
        [Then(@"I get some ""(.*)"" errors")]
        public void ThenIGetSomeErrors(string p0)
        {
            Assert.IsTrue(Browser.Driver2.PageSource.Contains(p0));
            
        }
    }
}
