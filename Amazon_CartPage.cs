using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using selenium_practice1.Test_util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_practice1.Pages
{
    class amazonCartPage
    {
        public string addButton = "//*[@id=\"addToCart_feature_div\"]/div[1]\r\n";

        public IWebDriver driver;

        public WebDriverUtility wd;
        public WebDriverWait wait;
        public amazonCartPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
            wd = new WebDriverUtility(driver);
        }
        public IWebElement addbutton => wd.FindElement(By.XPath(addButton));
        public void NavigateToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void clickOnAddButton
               ()
        {
            addbutton.Click();

            // var element = driver.FindElement
            //   (By.XPath(addButton));
            /*if (value)
            {
                wd.ClickElement(By.XPath(addButton));

                return true;
            }


            return false;*/

        }
       
    }
}
