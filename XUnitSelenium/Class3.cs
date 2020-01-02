using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace XUnitSelenium
{
    public class Class3
    {
        [Fact]
        public void Test()
        {
            using var context = new Context();
            var driver = new ChromeDriver(new ChromeOptions()
            {
                PageLoadStrategy = PageLoadStrategy.None
            });
            driver.Url = "http://www.o2.pl";
            driver.Navigate();
        }
    }
}