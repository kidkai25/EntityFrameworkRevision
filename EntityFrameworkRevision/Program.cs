using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace EntityFrameworkRevision
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDbContext context = new MyDbContext();
            
            //var studentsList = context.Students.Include("Class").ToList();
            var studentsList = context.Students.ToList();
            var x = context.Students.First();

            Class c1 = x.Class;

            //Console.WriteLine(c1.Name);
            foreach (var student in studentsList)
            {
                Console.WriteLine("StudentName " + student.StudentName);
                Console.WriteLine("Student Class " + student.Class.Name + " " + student.Class.Section);
            }

            Console.ReadLine();
        }
    }
}
