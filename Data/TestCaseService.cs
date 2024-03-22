using Microsoft.EntityFrameworkCore;
using System;

namespace TestAutomation.Data
{
    public class TestCaseService
    {
        #region Property
        private readonly ApiTestDBContext _appDBContext;
        #endregion

        #region Constructor
        public TestCaseService(ApiTestDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Test Cases
            #region Get List of Test Cases
            public async Task<List<TestCase>> GetAllTestCasesAsync()
            {
                return await _appDBContext.TestCase.ToListAsync();
            }
            #endregion

            #region Insert Test Case
            public async Task<bool> InsertTestCaseAsync(TestCase testcase)
            {
                await _appDBContext.TestCase.AddAsync(testcase);
                await _appDBContext.SaveChangesAsync();
                return true;
            }
		    #endregion

		    #region Update TestCase
		    public async Task<bool> UpdateTestCaseAsync(TestCase testcase)
		    {
			    _appDBContext.TestCase.Update(testcase);
			    await _appDBContext.SaveChangesAsync();
			    return true;
		    }
		    #endregion
		    #region Get TestCase by Id
		    public async Task<TestCase> GetTestCaseAsync(int Id)
		    {
			    TestCase testCase = await _appDBContext.TestCase.FirstOrDefaultAsync(c => c.Id.Equals(Id));
			    return testCase;
		    }
            #endregion

            #region DeleteTestCase
            public async Task<bool> DeleteTestCaseAsync(TestCase testCase)
            {
                _appDBContext.Remove(testCase);
                await _appDBContext.SaveChangesAsync();
                return true;
            }
        #endregion
        #endregion

        #region Test Inputs
        public async Task<List<TestCaseInput>> GetAllTestInputsAsync(int testCaseId)
        {
            return await _appDBContext.TestCaseInput.Include(x => x.TestCase).Where(x => x.TestCase.Id == testCaseId).ToListAsync();
        }
        public async Task<bool> InsertTestCaseInputAsync(TestCaseInput testCaseInput)
        {
            await _appDBContext.TestCaseInput.AddAsync(testCaseInput);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteTestCaseInputAsync(TestCaseInput testCaseInput)
        {
            _appDBContext.Remove(testCaseInput);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Test Outputs
        public async Task<List<TestCaseOutput>> GetAllTestOutputsAsync(int testCaseId)
        {
            return await _appDBContext.TestCaseOutput.Include(x => x.TestCase).Where(x => x.TestCase.Id == testCaseId).ToListAsync();
        }
        public async Task<bool> InsertTestCaseOutputAsync(TestCaseOutput testcaseOutput)
        {
            await _appDBContext.TestCaseOutput.AddAsync(testcaseOutput);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteTestCaseOutputAsync(TestCaseOutput testCaseOutput)
        {
            _appDBContext.Remove(testCaseOutput);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
