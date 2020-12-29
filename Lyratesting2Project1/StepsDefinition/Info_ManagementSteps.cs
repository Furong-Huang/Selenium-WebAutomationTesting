using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Lyratesting2Project1
{
    [Binding]
    public class Info_ManagementSteps
    {
        [Given(@"I am on the Information Management Page")]
        public void GivenIAmOnTheInformationManagementPage(Table table)
        {
            Lyratesting2Project1.Pages.HomePage.Goto();
            Lyratesting2Project1.Pages.HomePage.GotoLoginPage();
            Lyratesting2Project1.Pages.LoginPage.LoginSuccess(table.Rows[0][0], table.Rows[0][1]);
            Lyratesting2Project1.Pages.HomePage.GotoManageBackStage();
            Lyratesting2Project1.Pages.ManageBackStagePage.GoToOperationPage();
            Lyratesting2Project1.Pages.OperationPage.GotoInfoManagementPage();
        }
        
        [When(@"I want to do some searchs with multiple filters such as ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void WhenIWantToDoSomeSearchsWithMultipleFiltersSuchAsAndAndAnd(string category, string keyword, string property, string status)
        {
            Lyratesting2Project1.Pages.InfoManagementPage.InfoSearch(category, keyword, property, status);
        }
        
        [When(@"I want to change the status of an article")]
        public void WhenIWantToChangeTheStatusOfAnArticle()
        {
            Lyratesting2Project1.Pages.InfoManagementPage.ChangeStatus();
        }
        
        [When(@"I want to add a new category ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" on Info Management Page")]
        public void WhenIWantToAddANewCategoryAndAndAndAndAndOnInfoManagementPage(string category_name, string category_code, string parent_category, string SEO_title, string SEO_keyword, string SEO_description)
        {
            Lyratesting2Project1.Pages.InfoManagementPage.AddCategory(category_name, category_code, parent_category, SEO_title, SEO_keyword, SEO_description);
            Assert.IsTrue(Browser.Driver2.PageSource.Contains(category_code));
        }
        
        [When(@"I want to change the category name")]
        public void WhenIWantToChangeTheCategoryName(Table table)
        {
            Lyratesting2Project1.Pages.InfoManagementPage.ChangeCategoryName(table.Rows[0][0]);
            Assert.IsTrue(Browser.Driver2.PageSource.Contains(table.Rows[0][0].ToString()));
        }
        
        [Then(@"the (.*) search result should match the expected result")]
        public void ThenTheSearchResultShouldMatchTheExpectedResult(int search_result)
        {
            if (Browser.Driver2.PageSource.Contains("暂无页面记录"))
            {
                Assert.AreEqual(search_result, 0);
            }
            else
            {
                Assert.AreEqual(search_result, (Lyratesting2Project1.Pages.InfoManagementPage.GetArticles().Count));
            }
        }
        
        [Then(@"the UI should be updated accordingly")]
        public void ThenTheUIShouldBeUpdatedAccordingly()
        {
            Lyratesting2Project1.Pages.InfoManagementPage.CheckStatusChange();
        }
        
        [Then(@"the new category can be added and reflected on the UI")]
        public void ThenTheNewCategoryCanBeAddedAndReflectedOnTheUI()
        {
            
        }
        
        [Then(@"the new category name is reflected on the UI")]
        public void ThenTheNewCategoryNameIsReflectedOnTheUI()
        {
           
        }
    }
}
