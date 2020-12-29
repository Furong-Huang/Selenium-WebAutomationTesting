using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyratesting2Project1
{
    public static class Pages
    {
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }
        }

        public static LoginPage LoginPage
        {
            get
            {
                var loginPage = new LoginPage();
                PageFactory.InitElements(Browser.Driver, loginPage);
                return loginPage;
            }
        }

        public static RegisterPage RegisterPage
        {
            get
            {
                var registerPage = new RegisterPage();
                PageFactory.InitElements(Browser.Driver, registerPage);
                return registerPage;
            }
        }

        public static SettingPage SettingPage
        {
            get
            {
                var settingPage = new SettingPage();
                PageFactory.InitElements(Browser.Driver, settingPage);
                return settingPage;
            }
        }

        public static ManageBackStagePage ManageBackStagePage
        {
            get
            {
                var manageBackStagePage = new ManageBackStagePage();
                PageFactory.InitElements(Browser.Driver, manageBackStagePage);
                return manageBackStagePage;
            }
        }

        public static OrderPage OrderPage
        {
            get
            {
                var orderPage = new OrderPage();
                PageFactory.InitElements(Browser.Driver, orderPage);
                return orderPage;
            }
        }

        public static InfoManagementPage InfoManagementPage
        {
            get
            {
                var infoManagementPage = new InfoManagementPage();
                PageFactory.InitElements(Browser.Driver, infoManagementPage);
                return infoManagementPage;
            }
        }

        public static OperationPage OperationPage
        {
            get
            {
                var operationPage = new OperationPage();
                PageFactory.InitElements(Browser.Driver, operationPage);
                return operationPage;
            }
        }
    }
}
