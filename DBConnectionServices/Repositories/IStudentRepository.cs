using DBConnectionServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionServices.Repositories
{
    public interface IStudentRepository
    {
        Student GetById(int id);
        IEnumerable<Student> GetAll();
        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);
    }
}
