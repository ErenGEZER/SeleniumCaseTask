using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            string link = @"https://www.n11.com/";
            driver.Navigate().GoToUrl(link);

            driver.FindElements(By.ClassName("btnSignIn")).Click();
            driver.FindElements(By.Id("email")).SendKeys("xyz@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("xyz");
            driver.FindElements(By.Id("loginButton")).Click();
            driver.FindElements(By.Id("searchData")).SendKeys("samsung");
            driver.FindElements(By.ClassName("searchBtn")).Click();

            driver.FindElement(By.XPath(".//*[@id='contentListing']/div/div/div[2]/div[3]/a[2]")).Click();
            driver.FindElement(By.XPath(".//*[@id='p-208563481']/div/div[2]/span[2]")).Click();
            driver.FindElement(By.XPath(".//*[@id='wrapper']/div/div/div//div/div/div//div/div/div[9]/div[2]/a[2]")).Click();



        }
    }
}
