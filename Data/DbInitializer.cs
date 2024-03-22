namespace TestAutomation.Data
{
    public static class DbInitializer
    {
        public static async Task InitializeAsync(ApiTestDBContext context)
        {
            var testcase1 = new TestCase()
            {
              Name = "test1",
              ModuleName="Module1"
            };
            var testcase2 = new TestCase()
            {
                Name = "test2",
                ModuleName = "Module1"
            };
            var testcase3 = new TestCase()
            {
                Name = "test3",
                ModuleName = "Module1"
            };
            List<TestCase> seedTestCases = new List<TestCase>()
            {
                testcase1,
                testcase2,
                testcase3
            };
                

            var testcaseinput1 = new TestCaseInput()
            {
              Name = "ndc",
              Value = "ndcvalue1"
            };
            testcase1.Inputs = new List<TestCaseInput>();
            testcase1.Inputs.Add(testcaseinput1);

            var testcaseoutput1 = new TestCaseOutput()
            {
                Name = "output1",
                Value = "outputvalue1"
            };
            testcase1.Outputs = new List<TestCaseOutput>();
            testcase1.Outputs.Add(testcaseoutput1);

            var testcaserunthistory1 = new TestCaseRunHistory()
            {
              IssueDate = DateTime.Now,
              RunDate = DateTime.Now,
              Status = true
            };

            var testcaserunthistory2 = new TestCaseRunHistory()
            {
                IssueDate = DateTime.Now,
                RunDate = DateTime.Now,
                Status = false
            };
            testcase1.Histories = new List<TestCaseRunHistory>();
            testcase1.Histories.Add(testcaserunthistory2);
            await context.TestCase.AddRangeAsync(seedTestCases);
            context.SaveChanges();
        }
    }
}
