using System;

namespace Api.Integration.Framework.Models
{
    public class TestModel
    {
        public string Date { get; set; }
        public Test Test { get; set; }
    }

    public class Test
    {
        public string TestString { get; set; }
        public DateTime DateTime { get; set; }
    }
}
