using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using selenium_practice1.Test_util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*[contains(@class,'modal-innerl')]

namespace selenium_practice1.Pages
{
     public class Login_page
    {
        public string username = "//*[@id=\"login\"]/div/div/form/div[2]/input";
        public string password = "//*[@id=\"passwordInput\"]";
        public string loginbutton ="//*[@id='login']/div/div/form/div[4]/button";
        public string errormessage = "//*[@id=\"login\"]/div/div/form/div[1]/ul/li";
        public string mainspace1 = "//*[@id=\"unified-modere\"]/modere-unified-main/ng-component/div[1]/div/div/footer";
        public string mainspace = "//div[@id='promo-ribbon']/following-sibling::section/div[contains(@class,'modal-inner')]/a[contains(@class,'modal-close-icon')]";
        public string popscreen = "//*[@id='promo-modal']/div";

        public string donotshow = "//*[@id=\"promoSection\"]/p/a[@data-close='Close']";
       
        public IWebDriver driver;

        public WebDriverUtility wd;
        public WebDriverWait wait;
        public Login_page(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10000));
            wd = new WebDriverUtility(driver);
            wd.NavigateToPage("https://www.modere.co.in/");
            wd.SetPageLoadTimeout(10000);
        }
        public void NavigateToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        /*public bool IsElementClickable(By locator)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(locator));
                return true;
            }
            catch(WebDriverTimeoutException)
            {
                return false;
            }
        }*/
        public IWebElement mainSpace => wd.FindElement(By.XPath(mainspace));
        public void clearPopScreen()
        {
            Console.WriteLine("clear pop screen");
            // wd.ClickElement(By.XPath(mainspace));
            //mainSpace.Click();
            wd.ScrollToElement(By.XPath(donotshow));
            // IWebElement donot => wd.FindElement(By.XPath(donotshow));
            wd.ClickElement(By.XPath(donotshow));
        }

        public void EnterUsername(string Username)
        {
           // IWebElement usernameField=wd.FindElement(By.XPath(username));
            // usernameField.SendKeys(Username);
            wd.SendKeysToElement(By.XPath(username), Username);
        }
        public void EnterPassword(string Password)
        {
           // IWebElement passwordField = wd.FindElement(By.XPath(password));
            //passwordField.SendKeys(Password);
            wd.SendKeysToElement(By.XPath(password), Password);
        }
        public void ClickLoginButton()
        {
           // IWebElement loginButton = wd.FindElement(By.XPath(loginbutton));
            wd.ClickElement(By.XPath(loginbutton));
        }
        public string GetErrorMessage()
        {
            IWebElement errorMessage = wd.FindElement(By.XPath(errormessage));
            return errorMessage.ToString();
        }
    }
}
