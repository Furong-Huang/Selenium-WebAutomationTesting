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
    public class OperationPage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div[1]/a[1]")]
        private IWebElement infoManagementItem;

        public void GotoInfoManagementPage()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/div[2]/ul[1]/li[4]/a")));

            infoManagementItem.Click();
        }

    }
}
