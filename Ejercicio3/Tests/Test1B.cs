using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Ejercicio3.Resources;
using Ejercicio3.PageObject;
using Xunit;
using NUnit;
using Assert = Xunit.Assert;

namespace Ejercicio3.Tests
{
    public class Test1B : DriverFactory
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = init("https://www.ultimateqa.com/automation/");

        }

        [Test]
        public void ValidateSeleniumC()
        {
            //Navigate to seleniumc#
            IWebElement seleniumJava = driver.FindElement(By.LinkText("Selenium C#"));
            seleniumJava.Click();

            //Elements to assert
            IWebElement signIn = driver.FindElement(By.LinkText("Sign In"));
            IWebElement headerWrapper = driver.FindElement(By.CssSelector("div.header__wrapper"));
            IWebElement video = driver.FindElement(By.CssSelector("div.section__video__wrapper"));


            //Asserts
            Assert.Contains("seleniumms", driver.Url); 
            Assert.True(signIn.Displayed, "signin not displayed");
            Assert.True(headerWrapper.Displayed, "wrapper not displayed");
            Assert.True(video.Displayed, "video not displayed");



        }

        [TearDown]
        public void close()
        {
            Quit();
        }
    }
}