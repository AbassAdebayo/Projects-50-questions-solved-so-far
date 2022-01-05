using StudentAndDepartment.DTOs;
using StudentAndDepartment.Entities;

namespace StudentAndDepartment.Interfaces.Repositories
{
    public interface IStudentRepository
    {
        public StudentDto Create(Student student);

        public StudentDto Update(Student student);

        public bool Delete(Student student);

        public Student GetById(int id);
    }
}