using System;
using System.Collections.Generic;
using System.Linq;

public class ExpenseReport
{
    public long Id { get; set; }
    public Person Employee { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime ThruDate { get; set; }
    public string BusinessPurpose { get; set; }
    public ReportStatus Status { get; set; }
    public List<Expense> Details { get; set; }
    public string DefaultAccounting { get; set; }
    
    
    //constructor
    public ExpenseReport()
    {
        Id = 0;
        Employee = new Person { Id = 0, FirstName = "", LastName = "" };
        StartDate = DateTime.Now;
        ThruDate = DateTime.Now.AddDays(7);  // is this default ok?
        Status = ReportStatus.Draft;
        Details = new List<Expense>();
        DefaultAccounting = "CC1000";
    }

    public long Save()
    {
        Console.WriteLine("Expense Report Saved");
        return RandomID.GetId(10000);
    }

    public Expense AddExpense(Expense expense)
    {
        Details.Add(expense);
        return expense;
    }

    public static void Show(ExpenseReport report)
    {
        Console.WriteLine("Employee ID: {0}", report.Id.ToString());
        Console.WriteLine("Expense Report status code: {0}", report.Status.ToString());
        Console.WriteLine("Expense Count: {0}", report.Details.Count().ToString());
    }
}
