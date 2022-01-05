using System.Collections.Generic;
using StudentAndDepartment.DTOs;
using StudentAndDepartment.Entities;

namespace StudentAndDepartment.Interfaces.Repositories
{
    public interface IDepartmentRepository
    {
        public DepartmentDto Create(Department department);
        
        public DepartmentDto Update(Department department);

        public void Delete(Department department);

        public Department GetById(int id);

        public IEnumerable<Student> GetAll();
    }
}