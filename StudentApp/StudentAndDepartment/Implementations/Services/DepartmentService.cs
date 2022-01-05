using System.Collections.Generic;
using StudentAndDepartment.Context;
using StudentAndDepartment.DTOs;
using StudentAndDepartment.Entities;
using StudentAndDepartment.Interfaces.Services;

namespace StudentAndDepartment.Implementations.Services
{
    public class DepartmentService:IDepartmentService
    {
        private readonly StudentDbContextApp _departmentContext;

        public DepartmentService(StudentDbContextApp departmentContext)
        {
            _departmentContext = departmentContext;
        }
        public DepartmentDto Create(CreateDepartmentRequestModel model)
        {
            
        }

        public Department Update(Department department)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Department department)
        {
            throw new System.NotImplementedException();
        }

        public Department GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Department> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}