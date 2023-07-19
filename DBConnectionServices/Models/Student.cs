using System;
using System.Collections.Generic;

namespace DBConnectionServices.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? Dob { get; set; }
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}

