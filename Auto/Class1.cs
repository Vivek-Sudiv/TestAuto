using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Auto
{
    public class Class1
    {
        [Fact]
        public void Test1()
        {
            IWebDriver webdriver = new ChromeDriver();
            webdriver.Navigate().GoToUrl("https://www.amazon.in/");
            webdriver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("i phone xs max 512 gb");
            webdriver.FindElement(By.ClassName("nav-search-submit")).Click();
            Thread.Sleep(2000);
            webdriver.FindElement(By.XPath(".//span[contains(text(), 'Apple iPhone Xs (512GB) - Silver')]")).Click();
            Thread.Sleep(2000);
            webdriver.Quit();
        }
    }
}
