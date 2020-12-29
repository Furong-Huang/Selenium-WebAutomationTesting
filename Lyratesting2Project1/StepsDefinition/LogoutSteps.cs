using System;
using TechTalk.SpecFlow;

namespace Lyratesting2Project1
{
    [Binding]
    public class LogoutSteps
    {
        [Given(@"I am in the home page")]
        public void GivenIAmInTheHomePage()
        {
            Lyratesting2Project1.Pages.HomePage.Goto();
        }
        
        [Given(@"I can login my account")]
        public void GivenICanLoginMyAccount(Table table)
        {
            Lyratesting2Project1.Pages.HomePage.GotoLoginPage();
            Lyratesting2Project1.Pages.LoginPage.LoginSuccess(table.Rows[0][0], table.Rows[0][1]);
        }
        
        [When(@"I finish study and log out my account")]
        public void WhenIFinishStudyAndLogOutMyAccount()
        {
            Lyratesting2Project1.Pages.HomePage.LogOut();
        }
        
        [Then(@"I log out success")]
        public void ThenILogOutSuccess()
        {
            Lyratesting2Project1.Pages.LoginPage.CheckLogOut();
        }
    }
}
