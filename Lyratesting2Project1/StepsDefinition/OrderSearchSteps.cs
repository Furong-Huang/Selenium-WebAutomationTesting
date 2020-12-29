using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Lyratesting2Project1
{
    [Binding]
    public class OrderSearchSteps
    {
        [Given(@"I am on the order page")]
        public void GivenIAmOnTheOrderPage(Table table)
        {
            Lyratesting2Project1.Pages.HomePage.Goto();
            Lyratesting2Project1.Pages.HomePage.GotoLoginPage();
            Lyratesting2Project1.Pages.LoginPage.LoginSuccess(table.Rows[0][0], table.Rows[0][1]);
            Lyratesting2Project1.Pages.HomePage.GotoManageBackStage();
            Lyratesting2Project1.Pages.ManageBackStagePage.GoToOrderPage();
        }
        
        [When(@"I can do course search based on some conditions such as ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void WhenICanDoCourseSearchBasedOnSomeConditionsSuchAsAndAndAndAnd(string p0, string p1, string p2, string p3, string p4)
        {
            Lyratesting2Project1.Pages.OrderPage.SearchCourseOrder(p0, p1, p2, p3, p4);
        }
        
        [When(@"I can do class search based on some conditions such as ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void WhenICanDoClassSearchBasedOnSomeConditionsSuchAsAndAndAndAnd(string p0, string p1, string p2, string p3, string p4)
        {
            Lyratesting2Project1.Pages.OrderPage.SearchClassOrder(p0, p1, p2, p3, p4);
        }
        
        [Then(@"the (.*) order_result can be seen")]
        public void ThenTheOrder_ResultCanBeSeen(int numberOfResults)
        {
            Assert.AreEqual(numberOfResults, Lyratesting2Project1.Pages.OrderPage.GetOrders().Count);
        }
    }
}
