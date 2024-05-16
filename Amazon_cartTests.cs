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
     class amazonCartTests
    {
        
            private IWebDriver driver;
            private amazonCartPage cartPage;

            public WebDriverUtility wd;

            [SetUp]
            public void TestSetup()
            {

                driver = new ChromeDriver();
                cartPage = new amazonCartPage(driver);
               // cartPage.NavigateToPage("https://www.modere.co.in");
                wd = new WebDriverUtility(driver);
                wd.NavigateToPage("https://www.amazon.in/s?bbn=81107433031&rh=n%3A81107433031%2Cp_85%3A10440599031&_encoding=UTF8&content-id=amzn1.sym.58c90a12-100b-4a2f-8e15-7c06f1abe2be&pd_rd_r=ad706b6b-1b51-47a8-b0cc-e2d40b52a9bb&pd_rd_w=yGgDm&pd_rd_wg=GeZxh&pf_rd_p=58c90a12-100b-4a2f-8e15-7c06f1abe2be&pf_rd_r=E3BGQNZHNDD6ZHRRN0K0&ref=pd_hp_d_atf_unk");

            }

        [Test]
        public void ClickOnAddButtonTest1()
        {
            Console.WriteLine(cartPage.clickOnAddButton);
           
           // ClassicAssert.IsTrue(cartPage.clickOnAddButton
             //   (true),"Not all list elements are displayed.");
          
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
