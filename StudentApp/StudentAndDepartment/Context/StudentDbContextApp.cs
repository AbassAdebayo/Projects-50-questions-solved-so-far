using Microsoft.EntityFrameworkCore;
using StudentAndDepartment.Entities;

namespace StudentAndDepartment.Context
{
    public class StudentDbContextApp : DbContext

    {
        public StudentDbContextApp(DbContextOptions<StudentDbContextApp> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        

        }
        
        public DbSet<Student> Students { get; set; }
        
        public DbSet<Department> Departments { get; set; }
    }
    
    
    
}