using Student.Data.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Model;
namespace Student.Data
{
    public class StudentUoW : IStudentUoW
    {
        private EFRepository<Stud> _Students;
        private StudentContext _Context;

        public StudentUoW()
        {
            _Context = new StudentContext();
            _Students = new EFRepository<Stud>(_Context);
        }
        
        public IRepository<Stud> Students
        {
            get { return _Students; }
        }

        public void Commit()
        {
            _Context.SaveChanges();
        }
    }
}
