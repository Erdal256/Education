using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrder.Services
{
    public class SupplierRepository : Repository<Models.Supplier>, Interfaces.ISupplierRepository
    {
        public SupplierRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
