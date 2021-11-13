using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Text.Json;

namespace ChromeDriverUnitTest
{
    public class Tests
    {
        private IWebDriver driver;
        WebDriverWait wait;
        private string pageURL;
        private string userEmail = "lalalappochka@gmail.com";
        private string userPassword = "P@ssw0rd";
        private string typeofgraphic = "Connors RSI";

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
     //public void OpenPageSpot()
     //   {
     //       IWebElement PageSpot = driver.FindElement(By.XPath("//*[@id='HEADER-NAV']/a[3]"));
     //       PageSpot.Click();

     //   }
    [Test]
        public void Test1()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            driver.Manage().Window.Maximize();
            pageURL = "https://testnet.bybit.com/";
            driver.Navigate().GoToUrl(pageURL);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(12);
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='uniFrameHeader']/div[2]/div[1]/span[1]"));
            LoginButton.Click();
            IWebElement EmailField = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div/div/div/div[1]/div[2]/div/div[1]/div[1]/div/div[1]/div[2]/input"));
            EmailField.SendKeys(userEmail);
            IWebElement PasswordField = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div/div/div/div[1]/div[2]/div/div[1]/div[2]/div[1]/div[2]/input"));
            PasswordField.SendKeys(userPassword);
            IWebElement EnterField = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div/div/div/div[1]/div[2]/div/div[2]/div/a"));
            EnterField.Click();
            IWebElement Icon = driver.FindElement(By.XPath("//*[@id='uniFrameHeader']/div[2]/div[3]/div/div/div"));
            //IWebElement PageSpot = driver.FindElement(By.XPath("//*[@id='HEADER-NAV']/a[3]")); 
            //PageSpot.Click();
            driver.Navigate().GoToUrl("https://testnet.bybit.com/en-US/trade/spot/BTC/USDT");
            IWebElement AdvancedSection = driver.FindElement(By.XPath("//*[@id='root']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[1]/div/span[2]"));
            AdvancedSection.Click();
            IWebElement Indicators = driver.FindElement(By.XPath("//*[@id='header - toolbar - indicators']/div"));
            Indicators.Click();
            IWebElement FindTypeOfGraphic = driver.FindElement(By.XPath("//*[@id='overlap - manager - root']/div/div/div[2]/div[2]/div[1]/input"));
            FindTypeOfGraphic.SendKeys(typeofgraphic);
            IWebElement FieldConnorRSI = driver.FindElement(By.XPath("//*[@id='overlap - manager - root']/div/div/div[2]/div[2]/div[2]/div[1]/div/div/div/div"));
            FieldConnorRSI.Click();
            IWebElement ExitCross = driver.FindElement(By.XPath("//*[@id='overlap - manager - root']/div/div/div[3]/svg/path"));
            ExitCross.Click();



        }

    }
}