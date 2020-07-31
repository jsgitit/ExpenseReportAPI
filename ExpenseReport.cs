using System;
using System.Collections.Generic;

public class ExpenseReport
{
    public long Id { get; set; }
    public Person Employee { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime ThruDate { get; set; }
    public string BusinessPurpose { get; set; }
    public List<ExpenseDetail> Details { get; set; }
    public Enum Status { get; set; }
    
    //constructor
    public ExpenseReport()
    {
        Id = 0;
        Employee = new Person { Id = 0, FirstName = "", LastName = "" };
        Details = new List<ExpenseDetail>();
        StartDate = DateTime.Now;
    }
    
    public ExpenseDetail AddExpense(ExpenseDetail expense)
    {
        Details.Add(expense);
        return expense;
    }
    public static void Show(ExpenseReport report)
    {
        Console.WriteLine("Employee ID: {0}", Employee.Id.ToString());

    }
}
