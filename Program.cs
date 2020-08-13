using System;
using System.Runtime.CompilerServices;

namespace ExpenseReportAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = ExpenseReportBuilder
                .Default()
                .WithRandomCashExpenses()
                .Build();
            report.Id = report.Save();
            report.Show();
        }
    }
}
