using DBConnectionServices.Models;
using DBConnectionServices.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseConnection.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            var students = studentRepository.GetAll();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudentById(int id)
        {
            var student = studentRepository.GetById(id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }


        // GET api/products
        /*
        [HttpGet("/details")]
        public ActionResult<Student> GetStudentsById(int id)
        {
            var students = studentRepository.GetById(id);

            if (students == null)
                return NotFound();

            var std = students.Select(student => new Student
            {
                StudentId = student.StudentId,
                Name = student.Name,
            });

            return Ok(std);
        }
        */
    }
}
