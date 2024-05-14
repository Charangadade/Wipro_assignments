using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;


namespace selenium_practice1.Test_util
{
    public class WebDriverUtility
    {
        private IWebDriver driver;

       
        public WebDriverUtility(IWebDriver driver) 
        { 
            this.driver=driver;
            Console.WriteLine("WebDriverUtility constructor called");
        }

        public void NavigateToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
            Console.WriteLine("WebDriverUtility Navigate to page called");

        }

        public IWebElement FindElement(By locator)
        {
            try
            {
                Console.WriteLine("WebDriverUtility find element try called");
                return driver.FindElement(locator);
            }
            catch(Exception  ex) 
            {
                Console.WriteLine($"error while trying to click on the element {locator}");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    

        public void ClickElement(By locator)
        {
            try
            {
                //WebDriverWait wait = new WebDriverWait
                    //(driver, TimeSpan.FromSeconds(10));
                //wait.Until(ExpectedConditions.ElementToBeClickable(locator));
                Console.WriteLine("WebDriverUtility click element try called");
                FindElement(locator).Click();
              
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"error while trying to click on the element {locator}");
                Console.WriteLine(ex.Message);
                //return false;
            }
        }

        public ReadOnlyCollection<IWebElement> FindElements(By locator)
        {

            try
            {
                Console.WriteLine("WebDriverUtility find elements try called");
                return driver.FindElements(locator);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error while trying to click on the element {locator}");
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        public void setImplicitWait(TimeSpan timespan)
        {
            try
            {
                Console.WriteLine("WebDriverUtility set implicit wait try called");
                driver.Manage().Timeouts().ImplicitWait=timespan;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                
            }

        }
        

        // Method to perform explicit wait
        public void WaitForElement(By locator, TimeSpan timeout)
        {
            try
            {
                Console.WriteLine("WedDriverUtility wait for element called");
                var wait = new WebDriverWait(driver, timeout);
                wait.Until(ExpectedConditions.ElementExists(locator));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error waiting for element with locator: {locator}");
                Console.WriteLine(ex.Message);
            }
        }

        // Method to perform fluent wait
        public void FluentWaitForElement(By locator, TimeSpan timeout,
            TimeSpan pollingInterval)
        {
            try
            {
                Console.WriteLine("WedDriverUtility FluentWaitForElement called");
                var wait = new DefaultWait<IWebDriver>(driver)
                {
                    Timeout = timeout,
                    PollingInterval = pollingInterval
                };
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.Until(ExpectedConditions.ElementExists(locator));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error waiting for element with locator: {locator}");
                Console.WriteLine(ex.Message);
            }
        }

        // Method to perform a double click on an element
        public void DoubleClickElement(By locator)
        {
            try
            {
                Console.WriteLine("WedDriverUtility DoubleClickElement called");
                var element = FindElement(locator);
                var actions = new Actions(driver);
                actions.DoubleClick(element).Build().Perform();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error double clicking on element with locator: {locator}");
                Console.WriteLine(ex.Message);
            }
        }

        // Method to scroll to an element
        public void ScrollToElement(By locator)
        {
            try
            {
                var element = FindElement(locator);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error scrolling to element with locator: {locator}");
                Console.WriteLine(ex.Message);
            }
        }

        // Method to clear text from an input field
        public void ClearText(By locator)
        {
            try
            {
                FindElement(locator).Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error clearing text from element with locator: {locator}");
                Console.WriteLine(ex.Message);
            }
        }

        // Method to send keys to an input field
        public void SendKeysToElement(By locator, string text)
        {
            try
            {
                FindElement(locator).SendKeys(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending keys to element with locator: {locator}");
                Console.WriteLine(ex.Message);
            }
        }

        // Method to get text of an element
        public string GetText(By locator)
        {
            try
            {
                return FindElement(locator).Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting text from element with locator: {locator}");
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        // Method to get attribute value of an element
        public string GetAttributeValue(By locator, string attributeName)
        {
            try
            {
                return FindElement(locator).GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting attribute value from element with locator: {locator}");
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        // Method to check if an element is displayed
        public bool IsElementDisplayed(By locator)
        {
            try
            {
                return FindElement(locator).Displayed;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking if element is displayed with locator: {locator}");
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Method to check if an element is enabled
        public bool IsElementEnabled(By locator)
        {
            try
            {
                return FindElement(locator).Enabled;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking if element is enabled with locator: {locator}");
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Method to check if an element is selected
        public bool IsElementSelected(By locator)
        {
            try
            {
                return FindElement(locator).Selected;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking if element is selected with locator: {locator}");
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Method to navigate to a URL
        public void NavigateTo(string url)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error navigating to URL: {url}");
                Console.WriteLine(ex.Message);
            }
        }

        // Method to maximize the browser window
        public void MaximizeWindow()
        {
            try
            {
                driver.Manage().Window.Maximize();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error maximizing window: {ex.Message}");
            }
        }

        // Method to refresh the current page
        public void RefreshPage()
        {
            try
            {
                driver.Navigate().Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error refreshing page: {ex.Message}");
            }
        }

        // Method to get the title of the current page
        public string GetPageTitle()
        {
            try
            {
                return driver.Title;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting page title: {ex.Message}");
                return null;
            }
        }

        // Method to get the current URL
        public string GetCurrentURL()
        {
            try
            {
                return driver.Url;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting current URL: {ex.Message}");
                return null;
            }
        }

        // Method to switch to a frame by index
        public void SwitchToFrame(int index)
        {
            try
            {
                driver.SwitchTo().Frame(index);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error switching to frame by index {index}: {ex.Message}");
            }
        }

        // Method to switch to a frame by name or ID
        public void SwitchToFrame(string nameOrId)
        {
            try
            {
                driver.SwitchTo().Frame(nameOrId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error switching to frame with name or ID '{nameOrId}': {ex.Message}");
            }
        }

        // Method to switch to default content
        public void SwitchToDefaultContent()
        {
            try
            {
                driver.SwitchTo().DefaultContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error switching to default content: {ex.Message}");
            }
        }

        // Method to accept an alert
        public void AcceptAlert()
        {
            try
            {
                driver.SwitchTo().Alert().Accept();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error accepting alert: {ex.Message}");
            }
        }

        // Method to dismiss an alert
        public void DismissAlert()
        {
            try
            {
                driver.SwitchTo().Alert().Dismiss();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error dismissing alert: {ex.Message}");
            }
        }

        // Method to get text from an alert
        public string GetAlertText()
        {
            try
            {
                return driver.SwitchTo().Alert().Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting text from alert: {ex.Message}");
                return null;
            }
        }

        // Method to set a text in an alert
        public void SetAlertText(string text)
        {
            try
            {
                driver.SwitchTo().Alert().SendKeys(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting text in alert: {ex.Message}");
            }
        }

        // Method to drag and drop an element
        public void DragAndDropElement(By sourceLocator, By targetLocator)
        {
            try
            {
                var sourceElement = FindElement(sourceLocator);
                var targetElement = FindElement(targetLocator);
                var actions = new Actions(driver);
                actions.DragAndDrop(sourceElement, targetElement).Build().Perform();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error dragging and dropping element from {sourceLocator} to {targetLocator}: {ex.Message}");
            }
        }

        // Method to hover over an element
        public void HoverOverElement(By locator)
        {
            try
            {
                var element = FindElement(locator);
                var actions = new Actions(driver);
                actions.MoveToElement(element).Build().Perform();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error hovering over element with locator: {locator}");
                Console.WriteLine(ex.Message);
            }
        }

        // Method to execute JavaScript
        public void ExecuteJavaScript(string script)
        {
            try
            {
                ((IJavaScriptExecutor)driver).ExecuteScript(script);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing JavaScript: {ex.Message}");
            }
        }

        // Method to scroll to the top of the page
        public void ScrollToTop()
        {
            try
            {
                ExecuteJavaScript("window.scrollTo(0, 0);");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error scrolling to the top of the page: {ex.Message}");
            }
        }

        // Method to scroll to the bottom of the page
        public void ScrollToBottom()
        {
            try
            {
                ExecuteJavaScript("window.scrollTo(0, document.body.scrollHeight);");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error scrolling to the bottom of the page: {ex.Message}");
            }
        }
    }

}


