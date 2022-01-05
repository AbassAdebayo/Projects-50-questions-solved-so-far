using System.Collections.Generic;
using System.Linq;
using StudentAndDepartment.Context;
using StudentAndDepartment.DTOs;
using StudentAndDepartment.Entities;
using StudentAndDepartment.Interfaces.Repositories;

namespace StudentAndDepartment.Repositories
{
    public class DepartmentRepository: IDepartmentRepository
    {
        private readonly StudentDbContextApp _context;

        public DepartmentRepository(StudentDbContextApp context)
        {
            _context = context;
        }
        public DepartmentDto Create(CreateDepartmentRequestModel model)
        {
            var newDepartment = new DepartmentDto
            {
                Name = model.Name,
                DepartmentCode = model.DepartmentCode,

            };
            _context.Add(newDepartment);
            _context.SaveChanges();
            return new DepartmentDto
            {
                Name = model.Name,
                DepartmentCode = model.DepartmentCode
            };

        }

        public DepartmentDto Update(Department department)
        {
            _context.Departments.Update(department);
            return new DepartmentDto
            {
                Name = department.Name,
                DepartmentCode = department.DepartmentCode
            };
        }

        public void Delete(Department department)
        {
            _context.Departments.Remove(department);
            
        }

        public Department GetById(int id)
        {
            return _context.Departments.Find(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }
    }
}