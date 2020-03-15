using Microsoft.EntityFrameworkCore;
using ProductOrder.Models;

namespace ProductOrder
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.CustomerCustomerDemo>(a => a.HasKey(x => new { x.CustomerId, x.CustomerTypeId}));
            modelBuilder.Entity<Models.EmployeeTerritory>(a => a.HasKey(x => new { x.EmployeeId, x.TerritoryId}));
            modelBuilder.Entity<Models.OrderDetail>(a => a.HasKey(x => new { x.OrderId, x.ProductId}));
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
        public DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Territory> Territories { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}