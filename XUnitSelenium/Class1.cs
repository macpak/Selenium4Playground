using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace XUnitSelenium
{
    public class Class1
    {
        [Fact]
        public void Test()
        {
            using var context = new Context();
            var driver = new ChromeDriver(new ChromeOptions()
            {
                PageLoadStrategy = PageLoadStrategy.None
            });
            driver.Url = "http://www.onet.pl";
            driver.Navigate();
        }
    }
}