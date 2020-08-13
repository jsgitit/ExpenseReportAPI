using System;
using System.Collections.Generic;
using System.Globalization;
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

    }

    public long Save()
    {
        // do the save action and return the database Id
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
        Console.Write("\t\tEmployee ID: {0}", Employee.Id.ToString());
        Console.WriteLine("\t\t\tName: {0}", Employee.FullName);
        Console.Write("Default Accounting: {0}", DefaultAccounting);
        Console.Write("\tBusiness Purpose: {0}", BusinessPurpose);
        Console.WriteLine("\t\tReport Status: {0}", Status.ToString());
        Console.WriteLine("-----");
        Console.WriteLine();

        foreach (var expense in Details.OrderBy(d => d.TransactionDate))
        {
            Console.Write("ExpID: {0}", expense.Id.ToString());
            Console.Write("\tTrans Date: {0}", expense.TransactionDate.ToShortDateString());
            Console.Write("\tExp Category: {0}", expense.Category); 
            Console.WriteLine("\tAmount: {0}", expense.Amount.ToString("C", CultureInfo.CurrentCulture));
            Console.Write("Exp Type: {0}", expense.Type.ToString());
            Console.WriteLine("\t\tBus Purp: {0}", expense.BusinessPurpose);
            Console.WriteLine();
        }
        Console.WriteLine("-----");
        Console.Write("Total Expense Count: {0}", Details.Count().ToString());
        Console.Write("\t\t\t\tTotal Expense Report Amount: {0}", 
            Details.Sum(a => a.Amount).ToString("C",CultureInfo.CurrentCulture));
    }
}
