using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumExample
{
    [TestClass]
    public class UnitTest1
    {
        FirefoxDriver firefox;

        // это тест.
        [TestMethod]
        public void TestMethod1()
        {
            firefox = new FirefoxDriver();
            firefox.Navigate().GoToUrl("http://www.google.com/");
            firefox.FindElement(By.Id("gbqfq")).SendKeys("AutoQA.org");
            firefox.FindElement(By.Id("gbqfq")).SendKeys(Keys.Enter);
        }

        // разрушение объекта драйвера после окончание теста.
        [TestCleanup]
        public void TearDown()
        {
            firefox.Quit();
        }
    }
}