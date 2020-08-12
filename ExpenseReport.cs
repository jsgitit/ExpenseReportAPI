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
        Id = 10001;
        Employee = new Person { Id = 0, FirstName = "", LastName = "" };
        StartDate = DateTime.Now;
        ThruDate = DateTime.Now.AddDays(7);  // is this default ok?
        Status = ReportStatus.Draft;
        Details = new List<Expense>();
        DefaultAccounting = Employee.DefaultAccounting;
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

    public void Show()
    {
        Console.Write("Expense Report ID: {0}", Id);
        Console.Write("\tEmployee ID: {0}", Employee.Id.ToString());
        Console.Write("\tName: {0}", Employee.FullName);
        Console.WriteLine("\tDefault Accounting {0}", DefaultAccounting);
        Console.Write("Report Status: {0}", Status.ToString());
        Console.WriteLine("\t\t\tTotal Expense Count: {0}", Details.Count().ToString());
        Console.WriteLine();

        foreach (var expense in Details)
        {
            Console.Write("ExpID: {0}", expense.Id.ToString());
            Console.Write("\tTrans Date: {0}", expense.TransactionDate.ToShortDateString());
            Console.WriteLine("\tAmount: {0}", expense.Amount.ToString());
            Console.Write("\tExp Type: {0}", expense.Type.ToString());
            Console.Write("\tExp Category: {0}", expense.Category);
            Console.WriteLine("\tBus Purp: {0}", expense.BusinessPurpose);
        }
    }
}
