using System;
using System.Xml;
namespace Shared
{
    public class CommonLogic
    {
        public String GetShortDate()
        {
            return DateTime.Now.ToShortDateString();
        }

        public String GetAppUrl()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("environments.xml");
            XmlNode node = doc.SelectSingleNode("/Environments/Environment");
            String path = node.Attributes["url"].Value;
            return path;
        }

        public TestCaseException GetExceptionObj(String testClass, String testMethod, Exception exception)
        {
            TestCaseException testCaseException = new TestCaseException()
            {
                Id = Guid.NewGuid().ToString(),
                Date = DateTime.Now,
                TestClass = testClass,
                TestMethod = testMethod,
                ExceptionType = exception.GetType().ToString(),
                Message = exception.Message
            };

            return testCaseException;
        }
    }
}
