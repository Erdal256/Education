using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrder.Services
{
    public class EmployeeTerritoryRepository : Repository<Models.EmployeeTerritory>, Interfaces.IEmployeeTerritoryRepository
    {
        public EmployeeTerritoryRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
