using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lyratesting2Project1;

namespace LoginTest
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void TestLoginSuccess()
        {
            Lyratesting2Project1.Pages.HomePage.Goto();
            Lyratesting2Project1.Pages.HomePage.LoginAccount();
            //Lyratesting2Project1.Pages.LoginPage.LoginAccountSuccess(); 
            Lyratesting2Project1.Pages.LoginPage.LoginAccountSuccessWithSelectPSW();
            Lyratesting2Project1.Pages.HomePage.CheckAvatarSeen();
            Lyratesting2Project1.Pages.HomePage.LogOut();

        }
    }


}
