using GetAllTeachersByStudent.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAllTeachersByStudent.Data
{
    internal class SchoolDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=School;trusted_connection=true;");
        }

        public DbSet<Pupil>? Pupils { get; set; }
        public DbSet<Teacher>? Teachers { get; set; }
        public DbSet<Gender>? Genders { get; set; }
        public DbSet<Subject>? Subjects { get; set; }
    }
}
