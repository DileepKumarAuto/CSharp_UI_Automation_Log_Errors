using NUnit.Framework;
using OpenQA.Selenium;

using System;
using System.Threading;
using Shared;

namespace AutomationProject_1
{
    class Register : BaseTest
    {
        [SetUp]
        public void Start()
        {
            webDriver.Url = commonLogic.GetAppUrl();

            //Find the Pages link.
            IWebElement pagesLink = webDriver.FindElement(By.CssSelector("a[data-target='#collapsePages']"));
            pagesLink.Click();

            Thread.Sleep(1000);

            //Find and click on the Register link.
            IWebElement loginLink = webDriver.FindElement(By.CssSelector("a[href='register.html']"));
            loginLink.Click();
        }

        [Test]
        public void Test()
        {
            try
            {
                IWebElement email = webDriver.FindElement(By.Id("exampleInputEmail"));
                email.SendKeys("test@example.com");

                IWebElement firstName = webDriver.FindElement(By.Id("exampleFirstName"));
                firstName.SendKeys("John");

                IWebElement lastName = webDriver.FindElement(By.Id("exampleLastName"));
                lastName.SendKeys("Doe");

                Thread.Sleep(2000);                

                throw new OutOfMemoryException();

                Assert.Pass();
            }
            catch(Exception ex)
            {
                if (ex.GetType() != typeof(SuccessException))
                {
                    exceptionLog.AddException(commonLogic.GetExceptionObj("Register", "Test", ex));
                    Assert.Fail();
                }
            }            
        }
    }
}
