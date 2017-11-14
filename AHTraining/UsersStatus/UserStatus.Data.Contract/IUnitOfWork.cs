using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStatus.Model;

namespace UserStatus.Data.Contract
{
    public interface IUnitOfWork
    {
        IRepository<User> Users { get; }
        void Commit();
    }
}
