using System;
using TechTalk.SpecFlow;

namespace Lyratesting2Project1
{
    [Binding]
    public class UploadAvatarSteps
    {
        [Given(@"I am in the  home  page")]
        public void GivenIAmInTheHomePage()
        {
            Lyratesting2Project1.Pages.HomePage.Goto();
        }
        
        [Given(@"I can login  my  account")]
        public void GivenICanLoginMyAccount(Table table)
        {
            Lyratesting2Project1.Pages.HomePage.GotoLoginPage();
            Lyratesting2Project1.Pages.LoginPage.LoginSuccess(table.Rows[0][0], table.Rows[0][1]);
        }
        
        [When(@"I want to change my avatar")]
        public void WhenIWantToChangeMyAvatar()
        {
            Lyratesting2Project1.Pages.HomePage.GotoSettingPage();
        }
        
        [Then(@"I can upload my avatar successfully")]
        public void ThenICanUploadMyAvatarSuccessfully()
        {
            Lyratesting2Project1.Pages.SettingPage.ClickAvatarSetting();
            Lyratesting2Project1.Pages.SettingPage.UploadAvatar();
        }
    }
}
