using System.Collections.Generic;
using StudentAndDepartment.Entities;

namespace StudentAndDepartment.DTOs
{
    public class DepartmentDto
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public string DepartmentCode { get; set; }

        public IEnumerable<Student> Students { get; set; } = new List<Student>();

    }

    public class CreateDepartmentRequestModel
    {
        public string Name { get; set; }
        
        public string DepartmentCode { get; set; }

        public IEnumerable<Student> Students { get; set; } = new List<Student>();
    }
    
    public class UpdateDepartmentRequestModel
    {
        public string Name { get; set; }
        
        public string DepartmentCode { get; set; }

        public IEnumerable<Student> Students { get; set; } = new List<Student>();
    }
}