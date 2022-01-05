using System.Collections;
using System.Collections.Generic;

namespace StudentAndDepartment.Entities
{
    public class Department
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public string DepartmentCode { get; set; }

        public IEnumerable<Student> Students { get; set; } = new List<Student>();
    }
}