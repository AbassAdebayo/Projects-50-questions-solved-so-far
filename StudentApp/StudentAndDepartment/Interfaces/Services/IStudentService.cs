using StudentAndDepartment.DTOs;
using StudentAndDepartment.Entities;

namespace StudentAndDepartment.Interfaces.Services
{
    public interface IStudentService
    {
        public StudentDto Create(Student student);

        public StudentDto Update(Student student);

        public bool Delete(int id);

        public Student GetById(int id);
    }
}