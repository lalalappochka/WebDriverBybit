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
        [Test]
        public void Test1()
        {
            driver = new ChromeDriver(@"D:\WebDriver");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            driver.Manage().Window.Maximize();
            pageURL = "https://testnet.bybit.com/";
            driver.Navigate().GoToUrl(pageURL);


        }

    }
}