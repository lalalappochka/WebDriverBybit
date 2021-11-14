using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Text.Json;
using System.Diagnostics;

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
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(90);
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='uniFrameHeader']/div[2]/div[1]/span[1]"));
            LoginButton.Click();
            //IWebElement EmailField = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div/div/div/div[1]/div[2]/div/div[1]/div[1]/div/div[1]/div[2]/input"));
            //EmailField.SendKeys(userEmail);
            var element = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div/div/div/div[1]/div[2]/div/div[1]/div[1]/div/div[1]/div[2]/input"));

            for (int i = 0; i < userEmail.Length; i++)
            {
                element.SendKeys(userEmail[i].ToString());
            }
            IWebElement PasswordField = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div/div/div/div[1]/div[2]/div/div[1]/div[2]/div[1]/div[2]/input"));
            PasswordField.SendKeys(userPassword);

            IWebElement EnterField = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div/div/div/div[1]/div[2]/div/div[2]/div/a"));
            EnterField.Click();
            IWebElement Icon = driver.FindElement(By.XPath("//*[@id='uniFrameHeader']/div[2]/div[3]/div/div/div"));
            IWebElement Assets = driver.FindElement(By.XPath("//*[@id='uniFrameHeader']/div[2]/div[1]/div/div/div/span[1]"));
            Assets.Click();
            driver.Navigate().GoToUrl("https://testnet.bybit.com/user/assets/home");
            IWebElement Transfer = driver.FindElement(By.XPath("//*[@id='root']/div/main/aside/div/div[1]/div/button[3]"));
            Transfer.Click();
            //IWebElement AccountSend = driver.FindElement(By.XPath("//*[@id='modal - root']/div[1]/div/div[2]/div[1]/div[1]"));
            //AccountSend.Click();
            //IWebElement ChoiceSendAccount = driver.FindElement(By.XPath("//*[@id='modal - root']/div[1]/div/div[2]/div[1]/div[1]/div[3]/div[4]"));
            //ChoiceSendAccount.Click();
            //IWebElement AccountReceive = driver.FindElement(By.XPath("//*[@id='modal-root']/div[1]/div/div[2]/div[1]/div[3]"));
            //AccountSend.Click();
            //IWebElement ChoiceReceiver = driver.FindElement(By.XPath("//*[@id='modal - root']/div[1]/div/div[2]/div[1]/div[3]/div[3]/div[2]"));
            //ChoiceReceiver.Click();
            //IWebElement Coin = driver.FindElement(By.XPath("//*[@id='modal - root']/div[1]/div/div[2]/div[3]/div"));
            //Coin.Click();
            //IWebElement ChoiceBTC = driver.FindElement(By.XPath("//*[@id='modal - root']/div[2]/div/div/div/div[2]/div[1]/div/div/div[4]"));
            //ChoiceBTC.Click();
            IWebElement TransferableAmount = driver.FindElement(By.XPath("//*[@id='modal-root']/div[1]/div/div[2]/div[5]"));
            TransferableAmount.Click();

            IWebElement ConfirmButton = driver.FindElement(By.XPath("//*[@id='modal - root']/div[1]/div/div[2]/div[6]/button"));
            ConfirmButton.Click();



        }

    }
}