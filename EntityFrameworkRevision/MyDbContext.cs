using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EntityFrameworkRevision
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=EntityFrameworkRevision")
        {
            Database.SetInitializer<MyDbContext>(new StudentInitializer());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
    }
}
