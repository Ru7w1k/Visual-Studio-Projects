using Student.Model;

namespace Student.Data.Contract
{
    public interface IStudentUoW
    {
        IRepository<Stud> Students { get; }

        void Commit();
    }
}