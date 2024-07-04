using System;

namespace FinancialApp
{
    [Serializable]
    public abstract class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }

        public Transaction() { }

        public Transaction(int id, decimal amount, DateTime date, string description, string currency)
        {
            Id = id;
            Amount = amount;
            Date = date;
            Description = description;
            Currency = currency;
        }

        public abstract string TransactionType { get; }

        public override string ToString()
        {
            string idColumn = $"|  {Id}  ".PadRight(5);
            string amountColumn = $"|  {Amount} {Currency} ".PadRight(15);
            string dateColumn = $"|  {Date.ToShortDateString()}".PadRight(15);
            string descriptionColumn = $"|  {Description}   |".PadRight(22);
            string typeColumn = $"{TransactionType}   |".PadRight(10);

            return $"\n=====================================================================================\n" +
                   $"|  ID: |     Amount:   |     Date:     |  Description:      |  Transaction Type:    |\n" +
                   $"-------|---------------|---------------|--------------------|-----------------------|\n" +
                   $"{idColumn} {amountColumn} {dateColumn} {descriptionColumn} {typeColumn} \n" +      
                   $"=====================================================================================";
        }
    }
}
