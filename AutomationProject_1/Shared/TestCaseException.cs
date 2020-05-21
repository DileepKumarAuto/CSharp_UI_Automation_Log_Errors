using System;

namespace Shared
{
    public class TestCaseException
    {
        public String Id { get; set; }
        public DateTime Date { get; set; }
        public String TestClass { get; set; }
        public String TestMethod { get; set; }
        public String ExceptionType { get; set; }
        public String Message { get; set; }
    }
}
