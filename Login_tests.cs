using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using selenium_practice1.Pages;
using selenium_practice1.Test_util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Legacy;

namespace selenium_practice1.Tests
{
    [TestFixture]
     class Login_tests
    {
        private IWebDriver driver;
        private Login_page loginPage;

        //public WebDriverUtility wd;

        [SetUp]
        public void TestSetup()
        {

            driver = new ChromeDriver();
            loginPage = new Login_page(driver);
            // cartPage.NavigateToPage("https://www.modere.co.in");
            //wd = new WebDriverUtility(driver);
           // wd.NavigateToPage("https://www.modere.co.in");
           // wd.SetPageLoadTimeout(10000);

        }
        [Test]
        public void TestInvalidLogin()
        {
            loginPage.clearPopScreen();
            loginPage.EnterUsername("siri");
            loginPage.EnterPassword("1234");
            loginPage.ClickLoginButton();
            ClassicAssert.AreEqual("Invalid Login / Email or Password", 
                loginPage.GetErrorMessage);
              // Console.Write(loginPage.GetErrorMessage());
        }
        [Test]
        public void TestValidLogin()
        {
            loginPage.clearPopScreen();
            loginPage.EnterUsername("sireeshasiddi25@gmail.com");
            loginPage.EnterPassword("Sirisha.nana25");
            loginPage.ClickLoginButton();
            ClassicAssert.AreEqual("https://www.modere.co.in/", driver.Url);

        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
