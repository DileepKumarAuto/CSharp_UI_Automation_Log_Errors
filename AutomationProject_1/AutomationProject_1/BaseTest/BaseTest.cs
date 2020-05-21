using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Text;
using Shared;

namespace AutomationProject_1
{
    internal class BaseTest
    {
        protected IWebDriver webDriver;
        protected ExceptionLog exceptionLog;
        protected CommonLogic commonLogic;

        public BaseTest()
        {
            exceptionLog = ExceptionLogSingleton.GetInstance();
            webDriver = WebDriverSingleton.GetInstance();
            commonLogic = new CommonLogic();
        }
    }
}
