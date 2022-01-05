using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;
using StudentAndDepartment.Context;
using StudentAndDepartment.DTOs;
using StudentAndDepartment.Entities;
using StudentAndDepartment.Interfaces.Repositories;

namespace StudentAndDepartment.Repositories
{
    
    public class StudentRepository:IStudentRepository
    {
        private readonly StudentDbContextApp _context;

        public StudentRepository(StudentDbContextApp context)
        {
            _context = context;
        }
        public StudentDto Create(Student student)
        {
            var newStudent = new Student
            {
                FirstName = student.FirstName,
                Email = student.Email,
                LastName = student.LastName,
                PhoneNumber = student.PhoneNumber
                
            };
            _context.Add(student);
            _context.SaveChanges();
            return new StudentDto
            {
                FirstName = student.FirstName,
                Email = student.Email,
                LastName = student.LastName,
                PhoneNumber = student.PhoneNumber
            };


        }

        public StudentDto Update(Student student)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(Student student)
        {
            throw new System.NotImplementedException();
        }

        public StudentDto Update(StudentDto student)
        {
            _context.Update(student);
            _context.SaveChanges();
            return student;

        }

        public bool Delete(int id)
        {
            var check = _context.Students.SingleOrDefault(x => x.Id == id);
            
            _context.Remove(check);
            return true;
        }

        public Student GetById(int id)
        {
            var student = _context.Students.Find(id);
            return student;
        }
    }
}