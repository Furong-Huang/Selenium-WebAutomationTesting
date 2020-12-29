using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Lyratesting2Project1
{
    public class RegisterPage
    {
        [FindsBy(How = How.Id, Using = "register-btn")]
        private IWebElement registerBtn;
        [FindsBy(How = How.Id, Using = "register_email-error")]
        private IWebElement register_email_Error;
        [FindsBy(How = How.Id, Using = "register_nickname-error")]
        private IWebElement register_username_Error;
        [FindsBy(How = How.Id, Using = "register_password-error")]
        private IWebElement register_password_Error;
        [FindsBy(How = How.Id, Using = "captcha_code-error")]
        private IWebElement captcha_code_Error;
        [FindsBy(How = How.Id, Using = "register_email")]
        private IWebElement register_email;
        [FindsBy(How = How.Id, Using = "register_nickname")]
        private IWebElement register_username;
        [FindsBy(How = How.Id, Using = "register_password")]
        private IWebElement register_password;
        [FindsBy(How = How.Id, Using = "captcha_code")]
        private IWebElement resigter_captcha_code;

        public void Register(String nickname, String password, String email)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("register-btn")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("register_email")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("register_nickname")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("register_password")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("captcha_code")));

            register_email.SendKeys(email);
            register_username.SendKeys(nickname);
            register_password.SendKeys(password);
            resigter_captcha_code.SendKeys("");


        }



        public  void  Register(String nickname, String password, String email,String captcha_code)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("register-btn")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("register_email")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("register_nickname")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("register_password")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("captcha_code")));

            register_email.SendKeys(email);
            register_username.SendKeys(nickname);
            register_password.SendKeys(password);
            if(captcha_code == "null")
            {
                resigter_captcha_code.SendKeys("");
            }
            else
            {
                resigter_captcha_code.SendKeys(captcha_code);
            }

            registerBtn.Click();
        }

        //public void CheckErrorMsg(String error)
        //{

        //    if (Browser.Driver2.FindElements(By.Id("register_email-error")).Count() != 0)
        //    {
        //        Assert.IsTrue(register_email_Error.Text.Equals(error));
        //    }

        //    if (Browser.Driver2.FindElements(By.Id("register_nickname-error")).Count() != 0)
        //    {
        //        Assert.IsTrue(register_username_Error.Text.Equals(error));
        //    }

        //    if (Browser.Driver2.FindElements(By.Id("register_password-error")).Count() != 0)
        //    {
        //        Assert.IsTrue(register_password_Error.Text.Equals(error));
        //    }

        //    if (Browser.Driver2.FindElements(By.Id("captcha_code-error")).Count() != 0)
        //    {
        //        Assert.IsTrue(captcha_code_Error.Text.Equals(error));
        //    }
        //}

    }
}
