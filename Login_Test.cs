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
    public class carttests
    {
        private IWebDriver driver;
        private  cartpage cartPage;
 
        public WebDriverUtility wd;
 
        [SetUp]
        public void TestSetup()
        {
 
            driver = new ChromeDriver();
            cartPage = new cartpage(driver);
            cartPage.NavigateToPage("https://www.modere.co.in");
            wd = new WebDriverUtility(driver);
            wd.NavigateToPage("https://www.modere.co.in");
 
        }
 
        [Test]
        public void searchItems()
        {
 
           /* bool b = cartPage.cartItems.Contains
                (cartPage.item1);
            if (!b)
            {
                cartPage.cartItems.add(cartPage.item1);
                }*/
            foreach(var i in cartPage.cartItems)
            {
                bool isItemInCart=cartPage.cartItems.Contains(cartPage.item1);
                ClassicAssert.IsTrue(isItemInCart, "not present");
            }
 
        }
 
        [Test]
        public void ClickOnAddButtonTest1()
        {
        //bool isClickable = cartPage.addbutton.Displayed
        //  && cartPage.addbutton.Enabled;
 
            ClassicAssert.IsTrue(cartPage.clickOnAddButton
                (true),
                "Not all list elements are displayed.");
        }
        [Test]
        public void searchItems1()
        {
 
            foreach (var i in cartPage.cartItems)
            {
               Console.WriteLine(i.ToString());
            }
 
        }
 
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
