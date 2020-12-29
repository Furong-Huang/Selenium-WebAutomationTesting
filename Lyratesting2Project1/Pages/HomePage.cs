using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace Lyratesting2Project1
{
    public class HomePage
    {
        static string Url = "https://lyratesting2.co.nz/";

        private readonly IWebDriver driver = Browser.Driver2;


        [FindsBy(How = How.LinkText, Using = "登录")]
        private IWebElement loginLink;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/a/img")]
        private IWebElement avatar;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[9]/a")]
        private IWebElement logOutItem;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[9]/a")]
        private IWebElement logOutItem1;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[3]/a")]
        private IWebElement settingItem;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[6]/a")]
        private IWebElement manageBackStageItem;
        [FindsBy(How = How.LinkText, Using = "注册")]
        private IWebElement registerLink;


        public void GotoRegisterPage()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("注册")));

            registerLink.Click();
        }



        public void GotoLoginPage()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("登录")));

            loginLink.Click();
        }

        public void LogOut()
        {
            
                Actions action = new Actions(driver);
                action.MoveToElement(avatar).Perform();
                logOutItem.Click();
               
            
        }

        public void GotoSettingPage()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(avatar).Perform();
            settingItem.Click();
        }

        public void GotoManageBackStage()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(avatar).Perform();
            manageBackStageItem.Click();
        }


        public void CheckAvatarSeen()
        {
                WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[2]/a")));

                Assert.IsTrue(avatar.Displayed);

        }



        public void Goto()
        {
            Browser.Goto(Url);
        }

    }
}
