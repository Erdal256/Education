using System.ComponentModel.DataAnnotations;

namespace ProductOrder.Models
{
    public class Territory
    {
        [MaxLength(20)]
        public string Id { get; set; }

        [MaxLength(50)]
        public int TerritoryDescriptions { get; set; }

        public int RegionID { get; set; }
        public Region Region { get; set; }

        public EmployeeTerritory EmployeeTerritory { get; set; }
    }
}
