using System;

namespace FinancialApp
{
    [Serializable]
    public class Expense : Transaction
    {
        public string ExpenseType { get; set; }

        public Expense() { }

        public Expense(int id, decimal amount, DateTime date, string description, string currency, string expenseType)
            : base(id, amount, date, description, currency)
        {
            ExpenseType = expenseType;
        }

        public override string TransactionType => ExpenseType;
    }
}
