using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductOrder.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string CategoryName { get; set; }

        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public List<Product> Products { get; set; }
    }
}
