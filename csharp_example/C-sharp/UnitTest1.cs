using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace C_sharp
{
    [TestFixture]

    public class MyFirstTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]

        public void start()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Test]

        public void FirstTest ()
        {
            driver.Url = "http://wwww.google.com/";
            driver.FindElement(OpenQA.Selenium.By.Name("q")).SendKeys("webdriver");
            driver.FindElement(OpenQA.Selenium.By.Name("btnG")).Click();
            wait.Until(ExpectedConditions.TitleIs("webdriver - search in Google"));
        }

        [TearDown]

        public void stop()
        {
            driver.Quit();
            driver = null;
        }
    }
  }
