using Login.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Services
{
    public class UnitOfWork : Interfaces.IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public DataContext GetDataContext()
        {
            return _dataContext;
        }
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
            UserRepository = new UserRepository(_dataContext);
            EntryRepository = new EntryRepository(_dataContext);
        }
        public IUserRepository UserRepository { get; set; }
        public IEntryRepository EntryRepository { get; set; }

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
