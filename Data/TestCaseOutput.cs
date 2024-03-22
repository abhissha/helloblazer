using System.ComponentModel.DataAnnotations;

namespace TestAutomation.Data
{
    public class TestCaseOutput
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public String Value { get; set; }
        public TestCase TestCase { get; set; }
    }
}
