using NUnit.Framework;
using OpenQA.Selenium;

using System;
using System.Threading;
using Shared;

namespace AutomationProject_1
{
    class Buttons : BaseTest
    {
        [SetUp]
        public void Start()
        {
            webDriver.Url = commonLogic.GetAppUrl();

            //Find the Components link.
            IWebElement pagesLink = webDriver.FindElement(By.CssSelector("a[data-target='#collapseTwo']"));
            pagesLink.Click();

            Thread.Sleep(1000);

            //Find and click on the Buttons link.
            IWebElement loginLink = webDriver.FindElement(By.CssSelector("a[href='buttons.html']"));
            loginLink.Click();
        }

        [Test]
        public void Test()
        {
            try
            {
                IWebElement anchor = webDriver.FindElement(By.CssSelector("a[class='btn btn-primary btn-icon-split']"));
                anchor.Click();
                Thread.Sleep(2000);

                throw new DivideByZeroException();

                Assert.Pass();
            }
            catch(Exception ex)
            {
                if (ex.GetType() != typeof(SuccessException))
                {
                    exceptionLog.AddException(commonLogic.GetExceptionObj("Button", "Test", ex));
                    Assert.Fail();
                }
            }  
        }
    }
}
