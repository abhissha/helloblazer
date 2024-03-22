using System.ComponentModel.DataAnnotations;

namespace TestAutomation.Data
{
    public class TestCaseInput
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public virtual TestCase TestCase { get; set; }
    }
}
