using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductOrder.Models
{
    public class EmployeeTerritory
    {
        [Key]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        [Key, MaxLength (20)]
        public string TerritoryId { get; set; }

        [ForeignKey("TerritoryId")]
        public Territory Territory { get; set; }
    }
}
