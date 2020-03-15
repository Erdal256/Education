using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrder.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        ICategoryRepository CategoryRepository{ get; set; }
        ICustomerCustomerDemoRepository CustomerCustomerDemoRepository{ get; set; }
        ICustomerDemographicRepository CustomerDemographicRepository{ get; set; }
        ICustomerRepository CustomerRepository{ get; set; }
        IEmployeeRepository EmployeeRepository{ get; set; }
        IEmployeeTerritoryRepository EmployeeTerritoryRepository{ get; set; }
        IOrderDetailRepository OrderDetailRepository{ get; set; }
        IOrderRepository OrderRepository{ get; set; }
        IProductRepository ProductRepository{ get; set; }
        IRegionRepository RegionRepository{ get; set; }
        IShipperRepository ShipperRepository{ get; set; }
        ISupplierRepository SupplierRepository{ get; set; }
        ITerritoryRepository TerritoryRepository{ get; set; }
        int Complete();
    }
}
