using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.PageObject
{
    public class BasePageObject
    {
        protected IWebDriver driver;
        protected By verifyIfLoad;

        public BasePageObject(IWebDriver driver, By verifyIfLoad)
        {
            this.driver = driver;
            this.verifyIfLoad = verifyIfLoad;
        }


    }
}
