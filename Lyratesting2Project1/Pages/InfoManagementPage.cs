using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Lyratesting2Project1
{
    public class InfoManagementPage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div[1]/a[1]")]
        private IWebElement infoManagementItem;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[1]/div/a/span[2]")]
        private IWebElement categoryClick;
        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/input")]
        private IWebElement categoryInput;
        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/ul/li/div")]
        private IWebElement categorySelect;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/input")]
        private IWebElement keywordInput;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[3]/select")]
        private IWebElement propertySelect;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[4]/select")]
        private IWebElement statusSelect;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/button")]
        private IWebElement searchBtn;
        [FindsBy(How = How.CssSelector, Using = "[id^=article-] tbody tr")]
        private IList<IWebElement> articles;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr/td/div")]
        private IWebElement nullSearchResult;
        

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[7]/div/a[2]")]
        private IWebElement statusDropBtn;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[6]/span")]
        private IWebElement statusSituation; 
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[7]/div/ul/li[1]/a")]
        private IWebElement cancelPublish;
        private static string statusAfter = "";

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/ul/li[2]/a")]
        private IWebElement categoryManagementItem;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div/div/a")]
        private IWebElement categoryAddBtn;
        [FindsBy(How = How.Id, Using = "category-name-field")]
        private IWebElement categoryNameField;
        [FindsBy(How = How.Id, Using = "category-code-field")]
        private IWebElement categoryCodeField;
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/form/div[3]/div/div[1]/a/span[2]")]
        private IWebElement parentCategoryClick;
        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/div/input")]
        private IWebElement parentCategoryInput;
        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/ul/li/div")]
        private IWebElement parentCategorySelect;
        [FindsBy(How = How.Id, Using = "category-seoTitle-field")]
        private IWebElement categorySeoTitleField;
        [FindsBy(How = How.Id, Using = "category-seoKeyword-field")]
        private IWebElement categorySeoKeywordField;
        [FindsBy(How = How.Id, Using = "category-seoDesc-field")]
        private IWebElement categorySeoDescField;
        [FindsBy(How = How.Id, Using = "category-save-btn")]
        private IWebElement categorySaveBtn;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/ul[2]/li[2]/ul/li[1]/div/div[4]/a[1]")]
        private IWebElement categoryEditBtn;
        

        public void InfoSearch(string category, string keyword, string property, string status)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/div/a/span[2]")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/input")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[3]/select")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[4]/select")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/button")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[7]/div/a[2]")));


            infoManagementItem.Click();

            categoryClick.Click();
            categoryInput.SendKeys(category);
            categorySelect.Click();
            keywordInput.SendKeys(keyword);
            propertySelect.SendKeys(property);
            statusSelect.SendKeys(status);
            searchBtn.Click();
        }

        public void ChangeStatus()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[7]/div/a[2]")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[6]/span")));

            if (statusSituation.Text == "已发布")
            {
                statusDropBtn.Click();
                cancelPublish.Click();
                statusAfter = "未发布";
            }

            if(statusSituation.Text == "未发布")
            {
                statusDropBtn.Click();
                cancelPublish.Click();
                statusAfter = "已发布";
            }
        }

        public void CheckStatusChange()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(statusSituation.Text.Equals(statusAfter));
        }

        public IList<IWebElement> GetArticles()
        {
            return articles;
        }

        public void AddCategory(string category_name,string category_code, string parent_category, string SEO_title, string SEO_keyword, string SEO_description)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/ul/li[2]/a")));

            categoryManagementItem.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/div/div/a")));

            categoryAddBtn.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("category-name-field")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("category-code-field")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div/div[2]/form/div[3]/div/div[1]/a/span[2]")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("category-seoTitle-field")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("category-seoKeyword-field")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("category-seoDesc-field")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("category-save-btn")));

           
            categoryNameField.SendKeys(category_name);
            categoryCodeField.SendKeys(category_code);
            parentCategoryClick.Click();
            parentCategoryInput.SendKeys(parent_category);
            parentCategorySelect.Click();
            categorySeoTitleField.SendKeys(SEO_title);
            categorySeoKeywordField.SendKeys(SEO_keyword);
            categorySeoDescField.SendKeys(SEO_description);
            categorySaveBtn.Click();
        }

        public void ChangeCategoryName(string category_name)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/ul/li[2]/a")));

            categoryManagementItem.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/ul[2]/li[2]/ul/li[1]/div/div[4]/a[1]")));

            categoryEditBtn.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("category-name-field")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("category-save-btn")));

            categoryNameField.Clear();
            categoryNameField.SendKeys(category_name);
            categorySaveBtn.Click();
        }

    }
}
