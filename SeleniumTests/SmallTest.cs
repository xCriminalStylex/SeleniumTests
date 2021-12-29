using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class SmallTest : IDisposable
    {
        private IWebDriver _driver;
        public void Dispose()
        {
            _driver.Quit();
        }
        public IWebDriver StartDriverAndUrl(string url)
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl(url);
            return _driver;
        }
    }
}
