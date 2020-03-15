using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductOrder.Interfaces;

namespace ProductOrder.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
            CategoryRepository = new Services.CategoryRepository(_dataContext);
            CustomerCustomerDemoRepository = new Services.CustomerCustomerDemoRepository(_dataContext);
            CustomerDemographicRepository = new Services.CustomerDemographicRepository(_dataContext);
            CustomerRepository = new Services.CustomerRepository(_dataContext);
            EmployeeRepository = new Services.EmployeeRepository(_dataContext);
            EmployeeTerritoryRepository = new Services.EmployeeTerritoryRepository(_dataContext);
            OrderDetailRepository = new Services.OrderDetailRepository(_dataContext);
            OrderRepository = new Services.OrderRepository(_dataContext);
            ProductRepository = new Services.ProductRepository(_dataContext);
            RegionRepository = new Services.RegionRepository(_dataContext);
            ShipperRepository = new Services.ShipperRepository(_dataContext);
            SupplierRepository = new Services.SupplierRepository(_dataContext);
            TerritoryRepository = new Services.TerritoryRepository(_dataContext);
        }
        public ICategoryRepository CategoryRepository { get; set; }
        public ICustomerCustomerDemoRepository CustomerCustomerDemoRepository { get; set; }
        public ICustomerDemographicRepository CustomerDemographicRepository { get; set; }
        public ICustomerRepository CustomerRepository { get; set; }
        public IEmployeeRepository EmployeeRepository { get; set; }
        public IEmployeeTerritoryRepository EmployeeTerritoryRepository { get; set; }
        public IOrderDetailRepository OrderDetailRepository { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public IProductRepository ProductRepository { get; set; }
        public IRegionRepository RegionRepository { get; set; }
        public IShipperRepository ShipperRepository { get; set; }
        public ISupplierRepository SupplierRepository { get; set; }
        public ITerritoryRepository TerritoryRepository { get; set; }

        public int Complete()
        {
            return _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
