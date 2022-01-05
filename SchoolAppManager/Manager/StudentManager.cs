using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace StudentApp
{
    public class StudentManager
    {
        readonly StudentRepository studentRepository;
        List<Student> Students = new List<Student>();

        public StudentManager(MySqlConnection connection)
        {
            studentRepository = new StudentRepository(connection);
        }

        public void Create()
        {
            Console.WriteLine("Enter Your FirstName: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Your LastName: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Your Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Gender: ");
            string gender = Console.ReadLine();
            var student = new Student(firstName, lastName, email, phoneNumber, age, gender);
            studentRepository.Create(student);
        }

        public void Delete()
        {
            Console.WriteLine("Enter the RegNumber of the student you want to Find: ");
            string regNumber = Console.ReadLine();
            var result = studentRepository.Delete(regNumber);
            if (result)
            {
                Console.WriteLine("Record Deleted");
            }
            else
            {
                Console.WriteLine("An error occured");
            }
        }

        public void Update()
        {
            Console.WriteLine("Enter the RegNumber of the student you want to Find: ");
            string regNumber = Console.ReadLine();
            var row = studentRepository.FindByRegNumber(regNumber);
            if (!String.IsNullOrEmpty(row))
            {
                var student = Student.ConvertToStudent(row);
                student.UpdateInfo();
                var result = studentRepository.Update(student);
                if (result)
                {
                    Console.WriteLine("Record Updated");
                }
                else
                {
                    Console.WriteLine("An error occured");
                }
            }
            else
            {
                Console.WriteLine("No Matching record found");
            }
        }

        public void Find()
        {
            Console.WriteLine("Enter the RegNumber of the student you want to Find: ");
            string regNumber = Console.ReadLine();
            studentRepository.Find(regNumber);
        }

        public void List()
        {
            studentRepository.List();
        }
    }
}