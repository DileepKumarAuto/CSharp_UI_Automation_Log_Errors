using NUnit.Framework;
using OpenQA.Selenium;

using System;
using System.Threading;
using Shared;

namespace AutomationProject_1
{
    class Login : BaseTest
    {
        [SetUp]
        public void Start()
        {
            webDriver.Url = commonLogic.GetAppUrl();

            //Find the Pages link.
            IWebElement pagesLink = webDriver.FindElement(By.CssSelector("a[data-target='#collapsePages']"));
            pagesLink.Click();

            Thread.Sleep(1000);

            //Find and click on the Login link.
            IWebElement loginLink = webDriver.FindElement(By.CssSelector("a[href='login.html']"));
            loginLink.Click();
        }

        [Test]
        public void Test()
        {
            try
            {
                IWebElement email = webDriver.FindElement(By.CssSelector("input[type='email']"));
                email.SendKeys("test@example.com");
                Thread.Sleep(2000);

                throw new ElementNotSelectableException();

                Assert.Pass();
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(SuccessException))
                {
                    exceptionLog.AddException(commonLogic.GetExceptionObj("Login", "Test", ex));
                    Assert.Fail();
                }
            }
        }
    }
}
