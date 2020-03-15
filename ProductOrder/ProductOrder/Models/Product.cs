using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductOrder.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(40)]
        public string ProductName { get; set; }
        [MaxLength(20)]
        public string QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnStock { get; set; }
        public short ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
