using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace ChromeDriverUnitTest
{
    public class Tests
    {
        private IWebDriver driver;
        WebDriverWait wait;
        private string pageURL;
        private string userEmail = "lalalappochka@gmail.com";
        private string userPassword = "P@ssw0rd";

        //public void ChromeDriverCreating(IWebDriver driver)
        //{
        //    driver = new ChromeDriver(@"D:\WebDriver");
        //    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        //}

        //public void OpenTestnetBybitPage()
        //{
        //    driver.Manage().Window.Maximize();
        //    pageURL = "https://testnet.bybit.com/";
        //    driver.Navigate().GoToUrl(pageURL);
        //}

        //public void UserLogin()
        //{
        //    IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='uniFrameHeader']/div[2]/div[1]/span[1]"));
        //    LoginButton.Click();
        // IWebElement EmailField = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div/div/div/div[1]/div[2]/div/div[1]/div[1]/div/div[1]/div[2]/input"));
        //EmailField.SendKeys(userEmail);
        //IWebElement PasswordField = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div/div/div/div[1]/div[2]/div/div[1]/div[2]/div[1]/div[2]/input"));
        //PasswordField.SendKeys(userPassword)
        //IWebElement EnterField = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div/div/div/div[1]/div[2]/div/div[2]/div/a"));
       //EnterField.Click();
    //}
     public void OpenPageSpot()
        {
            IWebElement PageSpot = driver.FindElement(By.XPath("//*[@id='HEADER-NAV']/a[3]"));
            PageSpot.Click();

        }
    [Test]
        public void Test1()
        {
            driver = new ChromeDriver(@"D:\WebDriver");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            driver.Manage().Window.Maximize();
            pageURL = "https://testnet.bybit.com/";
            driver.Navigate().GoToUrl(pageURL);
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='uniFrameHeader']/div[2]/div[1]/span[1]"));
            LoginButton.Click();
            IWebElement EmailField = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div/div/div/div[1]/div[2]/div/div[1]/div[1]/div/div[1]/div[2]/input"));
            EmailField.SendKeys(userEmail);
            IWebElement PasswordField = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div/div/div/div[1]/div[2]/div/div[1]/div[2]/div[1]/div[2]/input"));
            PasswordField.SendKeys(userPassword);
            IWebElement EnterField = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div/div/div/div[1]/div[2]/div/div[2]/div/a"));
            EnterField.Click();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(17));
            IWebElement PageSpot = driver.FindElement(By.XPath("//*[@id='HEADER-NAV']/a[3]"));
            PageSpot.Click();

        }

    }
}