using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Ejercicio3.Resources;
using Ejercicio3.PageObject;
using Xunit;
using NUnit;
using Assert = Xunit.Assert;
using System.Collections;

namespace Ejercicio3.Tests
{
    public class Test2 : DriverFactory
    {
        IWebDriver driver;



        [SetUp]
        public void Setup()
        {
            driver = init("https://www.ultimateqa.com/automation/");

        }

        [Test]
        [Obsolete]
        public void ValidateCourses()
        {
            //Navigate to courses and search
            IWebElement courses = driver.FindElement(By.LinkText("Courses"));
            courses.Click();
            IWebElement searchBar = driver.FindElement(By.CssSelector("input[name=q]"));
            searchBar.SendKeys("selenium" + Keys.Enter);

            //Load List
            IList<IWebElement> lista = driver.FindElements(By.XPath("//div[@class='course-card__body']/h3"));

            
            foreach(IWebElement links in lista)
            {
                String text = links.GetAttribute("innerText");

               
                Assert.Contains("SELENIUM" , text);
               //No todos los resultados dicen Selenium
            }

        }

        [TearDown]
        public void close()
        {
            Quit();
        }
    }
}