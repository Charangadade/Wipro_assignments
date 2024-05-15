using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using selenium_practice1.Test_util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
 
namespace selenium_practice1.Pages
{
    class cartpage
    {
        public string Items = "//*[@id=\"cart-form\"]/div/ul";
        public string item = "//*[@id=\"17568IN-cart\"]/div[1]/div[1]/div[1]";
        public string addButton1 = "//*[@id=\"unified-modere\"]/modere-unified-main/ng-component/div[1]/div/div/div[5]/ng-component/div/product-details-cs-featured/div[2]/div[2]/div/div[1]/div[2]/form/div[4]/div[1]/button";
        public string addButton = "//*[@id=\"unified-modere\"]/modere-unified-main/ng-component/div[1]/div/div/div[5]/ng-component/div/product-details-cs-featured/div[2]/div[2]/div/div[1]/div[2]/form/div[4]/div[1]";
        public IWebDriver driver;
 
        public WebDriverUtility wd;
        public WebDriverWait wait;
        public cartpage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
            wd = new WebDriverUtility(driver);
        }
 
        public void NavigateToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
       public IWebElement item1=> wd.FindElement(By.XPath(item));
 
       /* public void addItem()
        {
 
            cartItems.add(item1);
        }*/
        public ReadOnlyCollection<IWebElement> cartItems =>
         wd.FindElements(By.XPath(Items));
 
        public IWebElement addbutton => wd.FindElement(By.XPath(addButton));
 
        public bool clickOnAddButton
              (bool value)
        {
 
            
            if (value )
            {
                wd.ClickElement(By.XPath(addButton));
 
                return true;
            }
            return false;
        }
 
 
        /* public bool AreAllCartitemsDisplayed()
         {
             IReadOnlyCollection<IWebElement> cartElements
                 = driver.FindElements(By.XPath(Items));
 
             foreach (IWebElement element in cartElements)
             {
 
                 if (!element.Enabled)
                 {
                     return false;
                 }
             }
 
             return true;
         }
        */
 
    }
}
