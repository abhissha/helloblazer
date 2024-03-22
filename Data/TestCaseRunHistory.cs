using System.ComponentModel.DataAnnotations;

namespace TestAutomation.Data
{
    public class TestCaseRunHistory
    {
        [Key]
        public int Id { get; set; }
        public TestCase TestCase { get; set; }
        public bool Status { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime RunDate { get; set; }
    }
}
