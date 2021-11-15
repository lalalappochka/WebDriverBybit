using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using System.Threading;

namespace ChromeDriverUnitTest
{
    public class Tests
    {
        private IWebDriver driver;
        WebDriverWait wait;
        private string pageURL;
        private string userEmail = "lalalappochka@gmail.com";
        private string userPassword = "P@ssw0rd";
        


        [OneTimeSetUp]
        public void StartTest()
        {
            Trace.Listeners.Add(new ConsoleTraceListener());
        }

        [Test]
        public void Test1()
        {
            //CookieImport.LoadCookies(@"D:\3_course\epam\WebDriverBybit\Cookie.json");

            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            driver.Manage().Window.Maximize();
            pageURL = "https://testnet.bybit.com/";
            driver.Navigate().GoToUrl(pageURL);

            //foreach (System.Net.Cookie cookie in CookieImport.CookieList)
            //{
            //    driver.Manage().Cookies.AddCookie(new OpenQA.Selenium.Cookie(cookie.Name, cookie.Value));
            //}
            //driver.Navigate().Refresh();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            IWebElement LoginButton = driver.FindElement(By.ClassName("header-login"));
            LoginButton.Click();
            IWebElement EmailField = driver.FindElements(By.CssSelector(".by-input-newui-field > .by-input-newui-field__input"))[0];
            EmailField.SendKeys(userEmail);
            //var element = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div/div/div/div[1]/div[2]/div/div[1]/div[1]/div/div[1]/div[2]/input"));
            //for (int i = 0; i < userEmail.Length; i++)
            //{
            //    element.SendKeys(userEmail[i].ToString());
            //}
            IWebElement PasswordField = driver.FindElements(By.CssSelector(".by-input-newui-field > .by-input-newui-field__input "))[1];
            PasswordField.SendKeys(userPassword);
            IWebElement EnterField = driver.FindElements(By.CssSelector(".log-newui-footer-submit "))[0];
            EnterField.Click();
            IWebElement Icon = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(driver => driver.FindElement(By.ClassName("icon-profile")));
            //IWebElement Icon = driver.FindElement(By.XPath("//*[@id='uniFrameHeader']/div[2]/div[3]/div/div/div"));
            IWebElement Assets = driver.FindElements(By.ClassName("by-dropdown--xx-large"))[3];
            Assets.Click();
            driver.Navigate().GoToUrl("https://testnet.bybit.com/user/assets/home");
            IWebElement Transfer = driver.FindElements(By.ClassName("operation-default-btn"))[1];
            Transfer.Click();
            IWebElement SenderAccount = driver.FindElement(By.CssSelector(".asset-transfer__account > .asset-transfer__account-wraper"));
            SenderAccount.Click();
            IWebElement ChoiceSendAccount = wait.Until(driver => driver.FindElements(By.CssSelector(".asset-transfer__account > .asset-transfer__account-list-wraper > .asset-transfer__account-list"))[2]);
            ChoiceSendAccount.Click();
            IWebElement AccountReceive = wait.Until(driver => driver.FindElements(By.CssSelector(".asset-transfer__account  > .asset-transfer__account-wraper"))[1]);
            AccountReceive.Click();
            IWebElement ChoiceReceiver = wait.Until(driver => driver.FindElements(By.CssSelector(".asset-transfer__account-list"))[1]);
            ChoiceReceiver.Click();
            IWebElement Coin = wait.Until(driver => driver.FindElement(By.CssSelector(".by-select-adv-selection-search-input")));
            Coin.Click();
            IWebElement ChoiceBTC = wait.Until(driver => driver.FindElements(By.CssSelector(".by-select-adv-item-option-content"))[3]);
            ChoiceBTC.Click();
            IWebElement TransferableAmount = driver.FindElement(By.CssSelector(".by-input__right-icon > .by-button.by-button--brand"));
            TransferableAmount.Click();
            
            //Thread.Sleep(3000);
            IWebElement ConfirmButton = driver.FindElement(By.ClassName("by-button--contained"));
            //IWebElement ConfirmButton = driver.FindElement(By.XPath("//*[@id='modal - root']/div[1]/div/div[2]/div[6]/button"));
            ConfirmButton.Click();
            //Thread.Sleep(3000);
            //ConfirmButton.Click();
            //Thread.Sleep(3000);
            //ConfirmButton.Click();



        }

    }
}