using System.ComponentModel.DataAnnotations;

namespace TestAutomation.Data
{
    public class TestCase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ModuleName { get; set; }
        public ICollection<TestCaseInput> Inputs { get; set; }
        public ICollection<TestCaseOutput> Outputs { get; set; }
        public ICollection<TestCaseRunHistory> Histories { get; set; }

    }
}

