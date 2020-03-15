using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrder.Services
{
    public class TerritoryRepository : Repository<Models.Territory>, Interfaces.ITerritoryRepository
    {
        public TerritoryRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
