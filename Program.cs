using System;
using System.Runtime.CompilerServices;

namespace ExpenseReportAPI
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            var expenseReport = new ExpenseReport()
            {
                Id = 2000,
                Employee = new Person() { Id = 1000, FirstName = "Jon", LastName = "Smart" },
                StartDate = DateTime.Now,
                ThruDate = DateTime.Now.AddDays(7),
                BusinessPurpose = "Sales Trip"
            };
            
            var expRptDetail = new ExpenseDetail
            {
                Id = 2000,
                TransactionDate = expenseReport.StartDate,
                Category = "Meals",
                Amount = 15.00d,
                BusinessPurpose = expenseReport.BusinessPurpose
            };
           
        }
    }
}
