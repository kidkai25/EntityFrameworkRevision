using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRevision
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual Class Class { get; set; } //Every student is associated with one grade
    }
}
