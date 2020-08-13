using ExpenseReportAPI;
using System;
using System.Collections.Generic;
using Xunit;

namespace ExpenseReportUnitTests
{
    public class ExpenseReportUnitTests
    {
        [Fact]
        public void CanCreateExpenseReport()
        {
            // arrange
            var report = new ExpenseReport()
            {
                Id = 2000,
                Employee = new Person()
                {
                    Id = 1000,
                    FirstName = "Jon",
                    LastName = "Smart"
                },
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
            Assert.Equal("Jon Smart", report.Employee.FullName);
            Assert.Equal(2, report.Details.Count);
        }
        [Fact]
        public void CanCreateReportUsingBuilder()
        {
            // arrange
            var report = ExpenseReportBuilder.Default().Build();

            // act

            // assert
            Assert.NotNull(report);
        }
        [Fact]
        public void CanCreateDefaultExpenseReport()
        {
            // arrange
            var report = ExpenseReportBuilder.Default().Build();

            // act

            // assert
            Assert.NotNull(report);
            Assert.NotEmpty(report.Employee.FullName);
            Assert.True(DateTime.Now > report.StartDate);
            Assert.Equal(0, report.Id);
            Assert.Equal(ReportStatus.Draft, report.Status);
            Assert.NotNull(report.Details);
            Assert.NotEmpty(report.DefaultAccounting);
        }
        [Fact]
        public void CanCreateExpenseReportWithRandomCashExpenses()
        {
            // arrange
            var report = ExpenseReportBuilder
                            .Default()
                            .WithRandomCashExpenses()
                            .Build();

            // act

            // assert
            Assert.NotNull(report);
            Assert.Equal(10, report.Details.Count);
        }
    }
}
