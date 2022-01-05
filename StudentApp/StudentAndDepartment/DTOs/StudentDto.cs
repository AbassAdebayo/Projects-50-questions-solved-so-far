using StudentAndDepartment.Entities;

namespace StudentAndDepartment.DTOs
{
    public class StudentDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        
        
        public class CreateStudentRequestModel
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }
            
            public string Email { get; set; }

            public string PhoneNumber { get; set; }
            
            public int DepartmentId { get; set; }
            
            public Department Department { get; set; }
        }
        
        public class UpdateStudentRequestModel
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }
            
            public string Email { get; set; }

            public string PhoneNumber { get; set; }
        }
    }
}