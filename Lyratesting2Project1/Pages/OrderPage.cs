using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Lyratesting2Project1
{
     public class OrderPage
    {
        [FindsBy(How = How.Id, Using = "startDate")]
        private IWebElement startDateInput;
        [FindsBy(How = How.Id, Using = "endDate")]
        private IWebElement endDateInput;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[1]")]
        private IWebElement statusSelect;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[2]")]
        private IWebElement paymentSelect;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/div[3]/select")]
        private IWebElement keywordTypeSelect;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/div[3]/input")]
        private IWebElement keywordContentInput;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/button")]
        private IWebElement searchBtn;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div/a[1]")]
        private IWebElement courseOrder;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div/a[2]")]
        private IWebElement classOrder;

        //定位元素可以使用通配的方法去定位所有以“order-table-“开始的id元素，注意它是一个集合
        [FindsBy(How = How.CssSelector, Using = "[id^=order-table-]")]
        private IList<IWebElement> orders;


        public void SearchCourseOrder(String date, String status,String payment,String keywordType,String keywordContent)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("startDate")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("endDate")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[1]")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[2]")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[3]/select")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[3]/input")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[1]/div/a[1]")));

            courseOrder.Click();

            startDateInput.SendKeys(date);

            if (date == "")
            {
                endDateInput.SendKeys("");
            }
            else
            {
                endDateInput.SendKeys(DateTime.Parse(date).AddMinutes(1).ToString("yyyy-MM-dd HH:mm"));
            }


            statusSelect.SendKeys(status);

            paymentSelect.SendKeys(payment);

            keywordTypeSelect.SendKeys(keywordType);

            keywordContentInput.SendKeys(keywordContent);

            searchBtn.Click();

        }

        public void SearchClassOrder(String date, String status, String payment, String keywordType, String keywordContent)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("startDate")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("endDate")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[1]")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[2]")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[3]/select")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[3]/input")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[1]/div/a[2]")));

            classOrder.Click();

            startDateInput.SendKeys(date);

            if (date == "")
            {
                endDateInput.SendKeys("");
            }
            else
            {
                endDateInput.SendKeys(DateTime.Parse(date).AddMinutes(1).ToString("yyyy-MM-dd HH:mm"));
            }
            

            statusSelect.SendKeys(status);

            paymentSelect.SendKeys(payment);

            keywordTypeSelect.SendKeys(keywordType);

            keywordContentInput.SendKeys(keywordContent);

            searchBtn.Click();

        }

        //定义一个方法，返回所有的条数
        public IList<IWebElement> GetOrders()
        {
            return orders;
        }

    }
}
