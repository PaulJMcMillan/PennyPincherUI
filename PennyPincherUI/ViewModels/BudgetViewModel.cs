using System.ComponentModel.DataAnnotations;

namespace PennyPincherUI.ViewModels
{
    public class BudgetViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public int FrequencyId { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PayDate { get; set; }
        public string Notes { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EntityId { get; set; }
        public int NumberOfPayments { get; set; }
        public string FrequencyName { get; set; } = string.Empty;
    }
}
