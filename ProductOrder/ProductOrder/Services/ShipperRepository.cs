using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrder.Services
{
    public class ShipperRepository : Repository<Models.Shipper>, Interfaces.IShipperRepository
    {
        public ShipperRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
