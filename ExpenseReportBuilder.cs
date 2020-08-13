using System;
using System.Collections.Generic;

namespace ExpenseReportAPI
{
    public class ExpenseReportBuilder
    {
        private ExpenseReport report;
        public ExpenseReportBuilder()
        {
            report = new ExpenseReport();
            report.Id = 0;
            report.Employee = new Person { Id = 22000, FirstName = "Jon", LastName = "Smart" };
            report.StartDate = DateTime.Now;
            report.ThruDate = DateTime.Now.AddDays(7);  // is this default ok?
            report.Status = ReportStatus.Draft;
            report.Details = new List<Expense>();
            report.DefaultAccounting = report.Employee.DefaultAccounting;
            report.BusinessPurpose = "Sales Meeting";
        }
        public static ExpenseReportBuilder Default()
        {
            return new ExpenseReportBuilder();
        }
        public ExpenseReportBuilder WithRandomCashExpenses()
        {
            var expCount = 10;
            string[] categoryList = { "Lodging", "Meals: Breakfast", "Meals: Lunch", "Meals: Dinner", "Car Rental" };
            for (int i = 0; i < expCount; i++)
            {
                report.Details.Add(new Expense()
                {
                    Id = i + 4000,
                    TransactionDate = report.StartDate.AddDays(RandomID.GetIdBetween(0, 4)),
                    Category = categoryList[RandomID.GetIdBetween(0, 4)],
                    Type = ExpenseType.Cash,
                    Amount = RandomID.GetIdBetween(100, 5000) / 100.00d,
                    BusinessPurpose = "Sales Meeting"
                });
            }
            return this;
        }
        public ExpenseReport Build()
        {
            return report;
        }
    }
}
