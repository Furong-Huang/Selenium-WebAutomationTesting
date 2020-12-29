using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Lyratesting2Project1
{
    [Binding]
    public class Update_Basic_InfomationSteps
    {
        [Given(@"I am in the  home page")]
        public void GivenIAmInTheHomePage()
        {
            Lyratesting2Project1.Pages.HomePage.Goto();
        }
        
        [Given(@"I can login my  account")]
        public void GivenICanLoginMyAccount(Table table)
        {
            Lyratesting2Project1.Pages.HomePage.GotoLoginPage();
            Lyratesting2Project1.Pages.LoginPage.LoginSuccess(table.Rows[0][0], table.Rows[0][1]);
        }
        
        [When(@"I update ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void WhenIUpdateAndAndAndAndAndAnd(string p0, string p1, string p2, string p3, string p4, string p5, string p6)
        {
            Lyratesting2Project1.Pages.HomePage.GotoSettingPage();
            Lyratesting2Project1.Pages.SettingPage.UpdateBasicInfo(p0, p1, p2, p3, p4, p5, p6);
        }
        
        [Then(@"the ""(.*)"" alert_message can be seen")]
        public void ThenTheAlert_MessageCanBeSeen(string p0)
        {
            Assert.IsTrue(Browser.Driver2.PageSource.Contains(p0));
        }
    }
}
