using System;
using System.Collections.Generic;

using Shared;
namespace AutomationProject_1
{
    public sealed class ExceptionLogSingleton
    {
        private static ExceptionLog instance = null;
        private ExceptionLogSingleton() { }

        public static ExceptionLog GetInstance()
        {
            if (instance == null)
            {
                ExceptionLog exceptionLog = new ExceptionLog();
                exceptionLog.Exceptions = new List<TestCaseException>();
                instance = exceptionLog;
            }
            return instance;
        }
    }

    public class ExceptionLog
    {
        public List<TestCaseException> Exceptions { get; set; }

        public void AddException(TestCaseException testCaseException)
        {
            if(Exceptions != null)
            {
                Exceptions.Add(testCaseException);
            }            
        }
    }
}
