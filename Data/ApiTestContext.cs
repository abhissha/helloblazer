using Microsoft.EntityFrameworkCore;

namespace TestAutomation.Data
{
    public class ApiTestDBContext : DbContext
    {
        public ApiTestDBContext(DbContextOptions<ApiTestDBContext> options) : base(options)
        {

        }
        public DbSet<TestCase> TestCase { get; set; }
        public DbSet<TestCaseInput> TestCaseInput { get; set; }
        public DbSet<TestCaseOutput> TestCaseOutput { get; set; }
        public DbSet<TestCaseRunHistory> TestCaseRunHistory { get; set; }


    }
}
