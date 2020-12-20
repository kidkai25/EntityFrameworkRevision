using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EntityFrameworkRevision
{
    class StudentInitializer : DropCreateDatabaseAlways<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {            
            Class C = new Class { ClassId = 1, Name = "CSE", Section = "1" };
            Class C2 = new Class { ClassId = 2, Name = "CSE", Section = "2" };

            Student student = new Student { Class = C, StudentId = 1, StudentName = "Light" };
            Student student2 = new Student { Class = C2, StudentId = 2, StudentName = "L" };

       
            context.Students.Add(student);
            context.Students.Add(student2);
            context.Classes.Add(C);
            context.Classes.Add(C2);

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
