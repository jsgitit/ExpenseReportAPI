using System;

public class Expense
{
    public long Id { get; set; }
    public long ExpenseReportId { get; set; }
    public DateTime TransactionDate { get; set; }
    public double Amount { get; set; }
    public ExpenseType Type { get; set; }
    public string Category { get; set; }
    public string BusinessPurpose { get; set; }
    public string Accounting { get; set; }
}