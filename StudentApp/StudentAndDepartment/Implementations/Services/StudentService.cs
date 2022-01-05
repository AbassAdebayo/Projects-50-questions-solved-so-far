using System.Collections.Generic;
using StudentAndDepartment.DTOs;
using StudentAndDepartment.Entities;
using StudentAndDepartment.Interfaces.Repositories;
using StudentAndDepartment.Interfaces.Services;

namespace StudentAndDepartment.Implementations.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;
        private readonly IDepartmentRepository _departmentRepository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }
        


        public StudentDto Create(StudentDto.CreateStudentRequestModel model)
        {
            var newStudent = new Student
                {
                    FirstName = model.FirstName,
                    Email = model.Email,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                    Department = model.Department


                };
                _repository.Create(newStudent);
                return new StudentDto
                {
                    FirstName = model.FirstName,
                    Email = model.Email,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                    Department = model.Department
                    
                };



        }

        public StudentDto Update(int id, StudentDto.UpdateStudentRequestModel model)
        {
            var student = _repository.GetById(id);
            if (student==null)
            {
                throw new KeyNotFoundException($"The Id does not exist");
            }

            return _repository.Update(student);
        }

        public StudentDto Create(Student student)
        {
            throw new System.NotImplementedException();
        }

        public StudentDto Update(Student student)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            var student = _repository.GetById(id);
            if (student==null)
            {
                throw new KeyNotFoundException($"The Id does not exist");
            }

            _repository.Delete(student);
            return true;
        }

        public Student GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}