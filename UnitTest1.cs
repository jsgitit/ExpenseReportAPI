using System;
using Xunit;
using ExpenseReportAPI;

namespace ExpenseReportUnitTests
{
    public class ExpenseReportUnitTests
    {
        [Fact]
        public void BuildExpenseReport()
        {
            // arrange
            var report = new ExpenseReport()
            {
                Id = 0,
                Employee = new Person { FirstName = "Jim", LastName = "Baker", Id = 2000 },
                Status = ReportStatus.Draft,
                BusinessPurpose = "Sales Trip"
            };

            // act
            report.Id = report.Save();

            // assert
            Assert.NotNull(report); 
            Assert.NotEqual(0, report.Id);
            Assert.Equal("Jim", report.Employee.FirstName);
        }

        [Fact]
        public void AddExpensesToReport()
        {
            // arrange
            
            // act
            
            // assert
        }
    }
}
