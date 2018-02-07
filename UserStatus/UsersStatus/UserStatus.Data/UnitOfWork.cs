using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStatus.Data.Contract;
using UserStatus.Model;

namespace UserStatus.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private EFRepository<User> _Users;
        private UserContext _Context;

        public UnitOfWork()
        {
            _Context = new UserContext();
            _Users = new EFRepository<User>(_Context);
        }

        public IRepository<User> Users
        {
            get { return _Users; }
        }

        public void Commit()
        {
            _Context.SaveChanges();
        }
    }
}
