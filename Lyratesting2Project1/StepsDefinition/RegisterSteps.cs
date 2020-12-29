using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Lyratesting2Project1
{
    [Binding]
    public class RegisterSteps
    {
        [Given(@"I am on register page")]
        public void GivenIAmOnRegisterPage()
        {
            Lyratesting2Project1.Pages.HomePage.Goto();
            Lyratesting2Project1.Pages.HomePage.GotoRegisterPage();
        }
        
        [When(@"I register with ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void WhenIRegisterWithAndAnd(string p0, string p1, string p2)
        {
            Lyratesting2Project1.Pages.RegisterPage.Register(p0, p1, p2);
        }
        
        [When(@"I can register with ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void WhenICanRegisterWithAndAndAnd(string p0, string p1, string p2, string p3)
        {
            Lyratesting2Project1.Pages.RegisterPage.Register(p0, p1, p2, p3);
        }
        
        [Then(@"I get some ""(.*)""error")]
        public void ThenIGetSomeError(string p0)
        {
            Assert.IsTrue(Browser.Driver2.PageSource.Contains(p0));
        }
    }
}
