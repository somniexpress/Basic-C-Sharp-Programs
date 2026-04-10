using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    public class SchoolContext : DbContext
    {
        // The base constructor can optionally pass a connection string.
        // If you omit it, EF will create a localdb database named "CodeFirstDemo.SchoolContext"
        public SchoolContext() : base()
        {
        }

        public DbSet<Student> Students{ get; set; }
    }
}

