using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumTests
{
    public class Gismeteo: SmallTest
    {

        
        private IWebDriver _driver;
        [Fact]
        public void TestWeatherTomorrow()
        {
            _driver = StartDriverAndUrl("https://www.gismeteo.ua/");
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            IWebElement element = _driver.FindElement(By.LinkText("Днепр (Днепропетровск)"));
            element.Click();
            element = _driver.FindElement(By.XPath("//a[2]/div/div/div/span"));
            element.Click();
            string actual = _driver.Url;
            Assert.Equal("https://www.gismeteo.ua/weather-dnipro-5077/tomorrow/", actual);

        }
        [Fact]
        public void TestOpenLinkDnepr()
        {
            _driver = StartDriverAndUrl("https://www.gismeteo.ua/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            IWebElement element = _driver.FindElement(By.LinkText("Днепр (Днепропетровск)"));
            element.Click();
            string actual = _driver.Url;
            Assert.Equal("https://www.gismeteo.ua/weather-dnipro-5077/", actual);
        }
        [Fact]
        public void TestOpenLinkDneprHumidity()
        {
            _driver = StartDriverAndUrl("https://www.gismeteo.ua/");
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            IWebElement element = _driver.FindElement(By.LinkText("Днепр (Днепропетровск)"));
            element.Click();
            element = _driver.FindElement(By.LinkText("Влажность"));
            element.Click();
            string actual = _driver.Url;
            Assert.Equal("https://www.gismeteo.ua/weather-dnipro-5077/#humidity", actual); 
        }
        [Fact]
        public void TestOpenMapWind()
        {
            _driver = StartDriverAndUrl("https://www.gismeteo.ua/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            IWebElement element = _driver.FindElement(By.CssSelector("body >" +
                " section.content > div.content_wrap > div > div.main" +
                " > div > div.map_horizontal.__frame.clearfix > div" +
                " > div.maps > div:nth-child(3) > div.img > a > img"));
            element.Click();
            string actual = _driver.Url;
            Assert.Equal("https://www.gismeteo.ua/maps/eur/wind/", actual);
        }
        [Fact]
        public void TestOpenLinkZaporizhiaSunAndMoon()
        {
            _driver = StartDriverAndUrl("https://www.gismeteo.ua/");
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            IWebElement element = _driver.FindElement(By.LinkText("Запорожье"));
            element.Click();
            element = _driver.FindElement(By.LinkText("Солнце и Луна"));
            element.Click();
            string actual = _driver.Url;
            Assert.Equal("https://www.gismeteo.ua/weather-zaporizhia-5093/#sun_moon", actual);
        }
        [Fact]
        public void TestWeatherSoftDesktop()
        {
            _driver = StartDriverAndUrl("https://www.gismeteo.ua/");
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            IWebElement element = _driver.FindElement(By.LinkText("Приложения"));
            element.Click();
            element = _driver.FindElement(By.XPath("//span[contains(.,'Компьютеров')]"));
            element.Click();
            element = _driver.FindElement(By.XPath("//a/div[2]"));
            element.Click();
            string actual = _driver.Url;
            Assert.Equal("https://www.gismeteo.ua/soft-desktop-chrome/", actual);
        }
        [Fact]
        public void TestOpenMapTemp()
        {
            _driver = StartDriverAndUrl("https://www.gismeteo.ua/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            IWebElement element = _driver.FindElement(By.XPath("//li[2]/a"));
            element.Click();
            element = _driver.FindElement(By.XPath("//a[3]/span"));
            element.Click();
            string actual = _driver.Url;
            Assert.Equal("https://www.gismeteo.ua/maps/eur/temp/", actual);
        }
        [Fact]
        public void TestOpenNews()
        {
            _driver = StartDriverAndUrl("https://www.gismeteo.ua/");
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            IWebElement element = _driver.FindElement(By.LinkText("Новости"));
            element.Click();
            element = _driver.FindElement(By.XPath("//li[2]/a/em"));
            element.Click();
            element = _driver.FindElement(By.XPath("//a/em"));
            element.Click();
            string actual = _driver.Url;
            Assert.Equal("https://www.gismeteo.ua/news/#1", actual);
        }
        [Fact]
        public void TestWeatherLozova10Days()
        {
            _driver = StartDriverAndUrl("https://www.gismeteo.ua/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            IWebElement element = _driver.FindElement(By.XPath("//div[5]/a/span[3]"));
            element.Click();
            element = _driver.FindElement(By.LinkText("10 дней"));
            element.Click();
            string actual = _driver.Url;
            Assert.Equal("https://www.gismeteo.ua/weather-lozova-5069/10-days/", actual);
        }
        [Fact]
        public void TestOpenMapPrc()
        {
            _driver = StartDriverAndUrl("https://www.gismeteo.ua/");
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement element = _driver.FindElement(By.CssSelector(".map:nth-child(1) img"));
            element.Click();
            element = _driver.FindElement(By.XPath("//span[contains(.,'Облачность')]"));
            element.Click();
            element = _driver.FindElement(By.XPath("//a[2]/span"));
            element.Click();
            string actual = _driver.Url;
            Assert.Equal("https://www.gismeteo.ua/maps/eur/prc/", actual);
        }
    }
}
