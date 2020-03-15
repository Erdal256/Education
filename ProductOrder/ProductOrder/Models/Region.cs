using System.ComponentModel.DataAnnotations;

namespace ProductOrder.Models
{
    public class Region
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public int RegionDescriptions { get; set; }

        public Territory Territory { get; set; }
    }
}
