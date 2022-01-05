using System.Collections.Generic;

namespace StudentAndDepartment.Entities
{
    public class Student
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        
        public  string LastName { get; set; }
        public string Email { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public int DepartmentId { get; set; }

        public IEnumerable<Student> Students { get; set; } = new List<Student>();

        public Department Department { get; set; }
        
    }
}