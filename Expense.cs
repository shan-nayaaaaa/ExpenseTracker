using System.ComponentModel;

namespace ExpenseTracker
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Today;
        public string Description { get; set; } = "";
        public string Category { get; set; } = "";
        public decimal Amount { get; set; }

        [DisplayName("Payment")]
        public string PaymentMethod { get; set; } = "";

        [DisplayName("Recurring")]
        public bool IsRecurring { get; set; }

        public string Notes { get; set; } = "";
    }
}