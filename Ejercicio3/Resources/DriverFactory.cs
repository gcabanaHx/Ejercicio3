using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Ejercicio3.Resources
{
    public class DriverFactory
    {
        static IWebDriver driver;
        public WebDriverWait wait ;


     
        public IWebDriver init(string url)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-notifications");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Window.Maximize();
            driver.Url = (url);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return driver;
        }


     
        public void Quit()
        {
            driver.Quit();
        }
       

    }
}
