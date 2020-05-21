using NUnit.Framework;
using OpenQA.Selenium;

using System;
using System.Threading;
using Shared;

namespace AutomationProject_1
{
    class Cards : BaseTest
    {
        [SetUp]
        public void Start()
        {
            webDriver.Url = commonLogic.GetAppUrl();

            //Find the Components link.
            IWebElement pagesLink = webDriver.FindElement(By.CssSelector("a[data-target='#collapseTwo']"));
            pagesLink.Click();

            Thread.Sleep(1000);

            //Find and click on the Cards link.
            IWebElement loginLink = webDriver.FindElement(By.CssSelector("a[href='cards.html']"));
            loginLink.Click();
        }

        [Test]
        public void Test()
        {
            try
            {
                IWebElement anchor = webDriver.FindElement(By.CssSelector("a[href='#collapseCardExample']"));
                anchor.Click();
                Thread.Sleep(2000);

                throw new ElementNotVisibleException();

                Assert.Pass();
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(SuccessException))
                {
                    exceptionLog.AddException(commonLogic.GetExceptionObj("Cards", "Test", ex));
                    Assert.Fail();
                }
            }            
        }
    }
}
