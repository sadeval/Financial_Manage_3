using System;

namespace FinancialApp
{
    [Serializable]
    public class Income : Transaction
    {
        public string IncomeType { get; set; }

        public Income() { }

        public Income(int id, decimal amount, DateTime date, string description, string currency, string incomeType)
            : base(id, amount, date, description, currency)
        {
            IncomeType = incomeType;
        }

        public override string TransactionType => IncomeType;
    }
}

