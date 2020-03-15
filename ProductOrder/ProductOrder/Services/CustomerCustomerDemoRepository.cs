using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrder.Services
{
    public class CustomerCustomerDemoRepository : Repository<Models.CustomerCustomerDemo>, Interfaces.ICustomerCustomerDemoRepository
    {
        public CustomerCustomerDemoRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
