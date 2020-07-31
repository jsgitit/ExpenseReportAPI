using System;

public class ExpenseDetail
{
    public long Id { get; set; }
    public ExpenseReport Report { get; set; }
    public DateTime TransactionDate { get; set; }
    public double Amount { get; set; }
    public string Type { get; set; }
    public string Category { get; set; }
    public string BusinessPurpose { get; set; }
}