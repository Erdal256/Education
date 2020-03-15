using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Services
{
    public class EntryRepository : Repository<Models.Entry>, Interfaces.IEntryRepository
    {
        private readonly DataContext _dataContext;
        public EntryRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
