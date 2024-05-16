using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using selenium_practice1.Test_util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace selenium_practice1.Pages
{
     class magentohomepage
    {
        public IWebDriver driver;

        public WebDriverUtility wd;
        public WebDriverWait wait;
        public magentohomepage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10000));
            wd = new WebDriverUtility(driver);
            //wd.NavigateToPage("https://magento.softwaretestingboard.com/");
            wd.SetPageLoadTimeout(10000);
        }
        public void NavigateToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }


        public string addElement = "//*[@id=\"product-addtocart-button\"]";
        public IWebElement addelement => wd.FindElement(By.XPath(addElement));
        public string product = "//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[3]/div/div/ol/li[6]";    
       public IWebElement Product=>wd.FindElement(By.XPath(product));

        public string clickCart = "/html/body/div[2]/header/div[2]/div[1]/a";
        public IWebElement clickcart => wd.FindElement(By.XPath(clickCart));

        public string proceedToCart = "//*[@id=\"top-cart-btn-checkout\"]";
        public IWebElement proceedtocart => wd.FindElement(By.XPath(proceedToCart));

        public string quantityText="//*[@id='cart-item-42612-qty']";
        public IWebElement quantitytext => wd.FindElement(By.XPath(quantityText));
        public string productQuantity = "//*[@id=\"cart-item-42260-qty\"]";
        public IWebElement productquantity => wd.FindElement(By.XPath(productQuantity));

        public string addProductMsg = "//*[@id=\"maincontent\"]/div[1]/div[2]/div/div/div";
        public IWebElement addproductmsg => wd.FindElement(By.XPath(addProductMsg));
        public string quantityUpdate = "//*[@id=\"update-cart-item-42612\"]";
        public IWebElement quantityupdate => wd.FindElement(By.XPath(quantityUpdate));
        public string signIn = "/html/body/div[2]/header/div[1]/div/ul/li[2]/a";
        public IWebElement signin=>wd.FindElement(By.XPath(signIn));

        public string Email = "//*[@id=\"email\"]";
        public IWebElement email => wd.FindElement(By.XPath(Email));

        public string Password = "//*[@id=\"pass\"]";
        public IWebElement password => wd.FindElement(By.XPath(Password));
        public string signinbutton = "//*[@id=\"send2\"]/span";
        public IWebElement SignInButton=>wd.FindElement(By.XPath(signinbutton));

        public string Product1 = "//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[3]/div/div/ol/li[1]/div/a/span/span";
        public IWebElement product1=>wd.FindElement(By.XPath(Product1));
        public string addProduct1 = "//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[3]/div/div/ol/li[1]/div/div/div[4]/div/div[1]/form/button/span";
        public IWebElement addproduct1 => wd.FindElement(By.XPath(addProduct1));
        public string homeFromBag = "/html/body/div[2]/div[2]/ul/li[1]/a";
        public IWebElement homefrombag => wd.FindElement(By.XPath(homeFromBag));

        public string product1Color = "//*[@id=\"option-label-color-93-item-50\"]";
        public IWebElement product1color => wd.FindElement(By.XPath(product1Color));
        public string product1Size = "//*[@id=\"option-label-size-143-item-168\"]";
        public IWebElement product1size=>wd.FindElement(By.XPath(product1Size));

        public string product1AddMsg = "//*[@id=\"maincontent\"]/div[2]/div[2]/div/div/div";
        public IWebElement product1addmsg => wd.FindElement(By.XPath(product1AddMsg));

        public void mouseHover()
        {
            wd.HoverOverElement(By.XPath(Product1));
        }
        public void clearQuantityText()
        {
            wd.DoubleClickElement(By.XPath(productQuantity));
            //productquantity.Click();
            wd.ClearText(By.XPath(productQuantity));
        }
        public void typeQuantityText(string num)
        {
            wd.SendKeysToElement(By.XPath(productQuantity), num);
        }
        public void FluentWait()
        {
           // wd.FluentWaitForElement(By.XPath(addElement), 
             //   TimeSpan.FromSeconds(20),TimeSpan.FromSeconds(10));
            // wd.setImplicitWait(TimeSpan.FromSeconds(5000));
            wait.Until(ExpectedConditions.ElementIsVisible
                (By.XPath("/html/body/div[2]/header/div[2]/div[1]/a/span[2]")));
           //wait for the add product message to get displayed
            wd.WaitForElement(By.XPath(product1AddMsg), TimeSpan.FromSeconds(10000));
        }
       public void EnterUserName()
        {
            wd.SendKeysToElement(By.XPath(Email), "sireeshasiddi25@gmail.com");
        }

        public void EnterPassword()
        {
            wd.SendKeysToElement(By.XPath(Password), "Sirisha.nana25");
        }
        public void scrollToProduct1()
        {
            wd.ScrollToElement(By.XPath(Product1));
        }

    }
}
