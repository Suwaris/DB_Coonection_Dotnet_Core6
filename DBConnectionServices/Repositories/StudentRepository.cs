using DBConnectionServices.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionServices.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolContext schoolContext;

        public StudentRepository(SchoolContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }

        public Student GetById(int id)
        {
            return schoolContext.Students.Find(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return schoolContext.Students.ToList();
        }

        public void Add(Student student)
        {
            schoolContext.Students.Add(student);
            schoolContext.SaveChanges();
        }

        public void Update(Student student)
        {
            schoolContext.Students.Update(student);
            schoolContext.SaveChanges();
        }

      
        public void Delete(Student student)
        {
            schoolContext.Students.Remove(student);
            schoolContext.SaveChanges();
        }
    }
}
