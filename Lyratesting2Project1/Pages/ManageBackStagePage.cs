using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Lyratesting2Project1
{
     public class ManageBackStagePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/ul[1]/li[4]/a")]
        private IWebElement orderPageLink;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/ul[1]/li[3]/a")]
        private IWebElement operationLink;


        public void GoToOrderPage()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/div[2]/ul[1]/li[4]/a")));

            orderPageLink.Click();
        }

        public void GoToOperationPage()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/div[2]/ul[1]/li[3]/a")));

            operationLink.Click();
        }

    }
}
