using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyratesting2Project1
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "login_username")]
        private IWebElement username;
        [FindsBy(How = How.Id, Using = "login_password")]
        private IWebElement password;
        [FindsBy(How = How.CssSelector, Using = ".btn")]
        private IWebElement loginButton;
        [FindsBy(How = How.Name, Using = "_remember_me")]
        private IWebElement selectPSW;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/form/div[1]")]
        private IWebElement errorMsg;
        [FindsBy(How = How.LinkText,Using = "找回密码")]
        private IWebElement passwordReset;
        [FindsBy(How = How.Id, Using = "form_email")]
        private IWebElement emailInput;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div/div/form[1]/div[2]/div/button")]
        private IWebElement pswResetBtn ;
        [FindsBy(How = How.Id, Using = "alertxx")]
        private IWebElement registerEmailAlert;
        [FindsBy(How = How.Id, Using = "form_email-error")]
        private IWebElement registerEmaiFormatlAlert;

        


        public void LoginSuccess(string name,string psw)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_username")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_password")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".btn")));

            username.Clear();
            username.SendKeys(name);
            password.Clear();
            password.SendKeys(psw);
            loginButton.Click();

        }

        public void LoginSuccessWithSelectRememberMe(string name, string psw)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_username")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_password")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[1]/div/div[2]/form/div[4]/button")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("_remember_me")));

            username.Clear();
            username.SendKeys(name);
            password.Clear();
            password.SendKeys(psw);
            if(selectPSW.Selected == false)
            {
                selectPSW.Click();
            }

            loginButton.Click();

        }

        public void LoginFail(string name, string psw)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_username")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_password")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[1]/div/div[2]/form/div[4]/button")));

            username.Clear();
            username.SendKeys(name);
            password.Clear();
            password.SendKeys(psw);
            loginButton.Click();

        }

        public void CheckLoginErrorMsg()
        {
            Assert.IsTrue(errorMsg.Text.Equals("用户名或密码错误"));
        }

        public void CheckLogOut()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[1]/div/div[2]/form/div[4]/button")));

            Assert.IsTrue(loginButton.Text.Equals("登录"));

        }

        public void ClickResetPsw()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("找回密码")));

            passwordReset.Click();
        }

        public void ResetPswWithEmail(String email)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[1]/div/div/div/form[1]/div[2]/div/button")));
         
            emailInput.SendKeys(email);
            pswResetBtn.Click();

        }

        public void CheckResetErrorMsg(String error)
        {

           if(Browser.Driver2.FindElements(By.Id("alertxx")).Count()!=0)
            {
                Assert.IsTrue(registerEmailAlert.Text.Equals(error));
            }

            if (Browser.Driver2.FindElements(By.Id("form_email-error")).Count() != 0)
            {
                Assert.IsTrue(registerEmaiFormatlAlert.Text.Equals(error));
            }
        }

    }
}
