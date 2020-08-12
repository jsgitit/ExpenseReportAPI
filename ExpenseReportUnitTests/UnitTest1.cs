using System;
using Xunit;
using ExpenseReportAPI;
using System.Collections.Generic;

namespace ExpenseReportUnitTests
{
    public class ExpenseReportUnitTests
    {
        [Fact]
        public void CreateDefaultExpenseReport()
        {
            // arrange
            var report = new ExpenseReport()
            {
                Id = 2000,
                Employee = new Person() { Id = 1000, FirstName = "Jon", LastName = "Smart" },
                StartDate = DateTime.Now,
                ThruDate = DateTime.Now.AddDays(7),
                BusinessPurpose = "",
                Status = ReportStatus.Draft,
                Details = new List<Expense>()
                {
                    new Expense()
                    {
                        Id = 4000,
                        TransactionDate = DateTime.Now,
                        Category = "Meals",
                        Type = ExpenseType.Cash,
                        Amount = 15.00d,
                        BusinessPurpose = "Sales Meeting"
                    },

                    new Expense()
                    {
                        Id = 4001,
                        TransactionDate = DateTime.Now.AddDays(3),
                        Category = "Car Rental",
                        Type = ExpenseType.Cash,
                        Amount = 50.00d,
                        BusinessPurpose = "Sales Trip"
                    },
                }
            };

            // act
            report.Id = report.Save();
            report.Show();
            // assert
            Assert.NotNull(report); 
            Assert.NotEqual(0, report.Id);
            Assert.Equal("Jon", report.Employee.FirstName);
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
