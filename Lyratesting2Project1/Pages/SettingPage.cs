using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using System.Threading;
using NUnit.Framework;

namespace Lyratesting2Project1
{
     public class SettingPage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[1]/div/ul/li[3]/a")]
        private IWebElement avatarSetting;
        [FindsBy(How = How.Name, Using = "file")]
        private IWebElement fileInput;
        [FindsBy(How = How.Id, Using = "upload-avatar-btn")]
        private IWebElement saveButton;

        [FindsBy(How = How.Id, Using = "profile_truename")]
        private IWebElement truename_inputTx;
        [FindsBy(How = How.Id, Using = "profile_idcard")]
        private IWebElement ID_inputTx;
        [FindsBy(How = How.Id, Using = "profile_mobile")]
        private IWebElement phoneno_inputTx;
        [FindsBy(How = How.Id, Using = "profile_title")]
        private IWebElement title_inputTx;
        [FindsBy(How = How.Id, Using = "profile_site")]
        private IWebElement personalwebsite_inputTx;
        [FindsBy(How = How.Id, Using = "weibo")]
        private IWebElement weibo_inputTx;
        [FindsBy(How = How.Id, Using = "profile_qq")]
        private IWebElement qq_inputTx;
        [FindsBy(How = How.Id, Using = "profile-save-btn")]
        private IWebElement profile_saveBtn;


        



        public void ClickAvatarSetting()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[1]/div/div[1]/div/ul/li[3]/a")));

            avatarSetting.Click();
        }

        public void UploadAvatar()
        {

            fileInput.SendKeys(@"C:\Users\furon\Documents\Visual Studio 2017\Projects\Lyratesting2Project1\res\image.jpg");

            //Need a force wait here for Firefox.
            Thread.Sleep(3000);
            saveButton.Click();
        }

        public void UpdateBasicInfo(String turename, String ID, String phoneno, String title, String personal_website, String WeiBo, String QQ)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_truename")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_idcard")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_mobile")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_title")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_site")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("weibo")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_qq")));

            truename_inputTx.Clear();
            truename_inputTx.SendKeys(turename);

            ID_inputTx.Clear();
            ID_inputTx.SendKeys(ID);

            phoneno_inputTx.Clear();
            phoneno_inputTx.SendKeys(phoneno);

            title_inputTx.Clear();
            title_inputTx.SendKeys(title);

            personalwebsite_inputTx.Clear();
            personalwebsite_inputTx.SendKeys(personal_website);

            weibo_inputTx.Clear();
            weibo_inputTx.SendKeys(WeiBo);

            qq_inputTx.Clear();
            qq_inputTx.SendKeys(QQ);

            profile_saveBtn.Click();
        }





    }
}
