using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

[assembly: CollectionBehavior(MaxParallelThreads = 4)]

namespace XUnitSelenium
{
    public class Class2
    {
        public Class2()
        {
            var context = SynchronizationContext.Current;
        }
        
        [Fact]
        public void Test()
        {
            using var context = new Context();
            var driver = new ChromeDriver(new ChromeOptions()
            {
                PageLoadStrategy = PageLoadStrategy.None
            });
            driver.Url = "http://www.wp.pl";
            driver.Navigate();
        }
    }

    public class Context : IDisposable
    {
        private SynchronizationContext syncContext;

        public Context()
        {
            syncContext = SynchronizationContext.Current;
            SynchronizationContext.SetSynchronizationContext(null);
        }
        
        public void Dispose()
        {
            if(syncContext !=null)
                SynchronizationContext.SetSynchronizationContext(syncContext);
        }
    }
}