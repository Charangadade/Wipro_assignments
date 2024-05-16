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
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework.Legacy;

namespace selenium_practice1.Tests
{
     class magentohomeTests
    {
        private IWebDriver driver;
        private magentohomepage loginPage;

        public WebDriverUtility wd;
        public SoftAssert sa;
        public HardAssert ha;
        public WebDriverWait wait;

        [SetUp]
        public void TestSetup()
        {

            driver = new ChromeDriver();
            loginPage = new magentohomepage(driver);
            // cartPage.NavigateToPage("https://www.modere.co.in");
            wd = new WebDriverUtility(driver);
            wd.NavigateToPage("https://magento.softwaretestingboard.com/");
            sa = new SoftAssert();
             ha = new HardAssert();


            // wd.SetPageLoadTimeout(10000);

        }
        [Test]
        public void clickItems()
        {
            loginPage.signin.Click();
            loginPage.EnterUserName();
            loginPage.EnterPassword();
            loginPage.SignInButton.Click();


            loginPage.Product.Click();
            loginPage.addelement.Click();
            //loginPage.FluentWait();
           /* wd.setImplicitWait(TimeSpan.FromSeconds(10000));
           // wait.Until(ExpectedConditions.ElementDisplayed(loginPage.addproductmsg));
            // wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10000));*/
            wd.setImplicitWait(TimeSpan.FromSeconds(20000));

            ClassicAssert.IsTrue(loginPage.addproductmsg.Displayed, "no");
            loginPage.homefrombag.Click();
            loginPage.scrollToProduct1();
            loginPage.mouseHover();
            loginPage.product1color.Click();
            loginPage.product1size.Click();
            loginPage.mouseHover();
            loginPage.addproduct1.Click();

            //wd.setImplicitWait(TimeSpan.FromSeconds(20000));
            loginPage.FluentWait();
           // ClassicAssert.IsTrue(loginPage.product1addmsg.Displayed, "no");
           sa.IsTrue(loginPage.product1addmsg.Displayed, "no");

           //ha.IsFalse(loginPage.product1addmsg.Displayed, "no");

            loginPage.clickcart.Click();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10000));
            /*
            loginPage.quantitytext.Click();
            loginPage.clearQuantityText();
            loginPage.typeQuantityText("2");
            loginPage.quantityupdate.Click();
            loginPage.productquantity.Click();*/

            loginPage.proceedtocart.Click();


        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
