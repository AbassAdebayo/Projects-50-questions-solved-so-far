using System.Collections.Generic;
using StudentAndDepartment.DTOs;
using StudentAndDepartment.Entities;

namespace StudentAndDepartment.Interfaces.Services
{
    public interface IDepartmentService
    {
                public DepartmentDto Create(Department department);
                
                public DepartmentDto Update(Department department);
        
                public void Delete(Department department);
        
                public Department GetById(int id);
        
                public IEnumerable<Department> GetAll();
    }
}