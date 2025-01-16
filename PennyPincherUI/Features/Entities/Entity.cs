using System.ComponentModel.DataAnnotations;

namespace PennyPincherWebApi.Features.Entity
{
    public partial class Entity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool Active { get; set; } = true;
        public string Notes { get; set; } = string.Empty;
        public decimal LowestBalance { get; set; }
        public bool DefaultEntity { get; set; } = false;
        public int CustomerId { get; set; }
    }
}
