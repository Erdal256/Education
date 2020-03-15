using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrder.Services
{
    public class OrderDetailRepository : Repository<Models.OrderDetail>, Interfaces.IOrderDetailRepository
    {
        public OrderDetailRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
