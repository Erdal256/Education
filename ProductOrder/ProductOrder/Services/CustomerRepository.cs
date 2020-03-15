using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrder.Services
{
    public class CustomerRepository : Repository<Models.Customer>, Interfaces.ICustomerRepository
    {
        public CustomerRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
