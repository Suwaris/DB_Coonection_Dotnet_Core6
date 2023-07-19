using System;
using System.Collections.Generic;

namespace DBConnectionServices.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            //Students = new HashSet<Student>();
        }

        public int TeacherId { get; set; }
        public string Name { get; set; } = null!;
        public string Subject { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
