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
          
              firefox.Navigate().GoToUrl("http://2gis.ru/countries/global");
              firefox.FindElement(By.ClassName("world__searchInput")).SendKeys("Навосибирск");

              firefox.FindElement(By.ClassName("world__searchInput")).SendKeys(Keys.Enter);
            //  firefox.Navigate().GoToUrl("https://www.google.ru");
            //  firefox.FindElement(By.Id("lst-ib")).SendKeys("Новокузнецк");
            //  firefox.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
            Assert.AreEqual("http://2gis.ru/countries/global/novosibirsk", firefox.Url);
        }

        // разрушение объекта драйвера после окончание теста.
        [TestCleanup]
       public void TearDown()
        {
            firefox.Quit();
        }
    }
}