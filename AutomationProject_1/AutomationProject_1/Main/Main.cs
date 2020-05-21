using NUnit.Framework;
using OpenQA.Selenium;

using System;
using System.IO;
using System.Xml.Serialization;

using Shared;

namespace AutomationProject_1
{
    [SetUpFixture]
    public class Main
    {
        IWebDriver webDriver;

        [OneTimeSetUp]
        public void RunBeforeAllTests()
        {
            CommonLogic commonLogic = new CommonLogic();
            webDriver = WebDriverSingleton.GetInstance();
            webDriver.Url = commonLogic.GetAppUrl();
        }

        [OneTimeTearDown]
        public void RunAfterAllTests()
        {
            ExceptionLog exceptionLog = ExceptionLogSingleton.GetInstance();
            if(exceptionLog.Exceptions.Count > 0)
            {
                String fileName = String.Format("{0}_{1}.xml", "ExceptionLog", DateTime.Now.ToString("mmddyyyy-hhmmss"));
                XmlSerialize(typeof(ExceptionLog), exceptionLog, fileName);
            }
            
            webDriver.Close();
        }

        private void XmlSerialize(Type dataType, object data, string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(dataType);
            if (File.Exists(filePath)) File.Delete(filePath);
            TextWriter writer = new StreamWriter(filePath);
            xmlSerializer.Serialize(writer, data);
            writer.Close();
        }
    }
}
