using System;
using System.Collections.Generic;

namespace TestOnDelegat
{
    class Program
    {
        public delegate bool myDelegate(Student student);
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student(
                "Adewale",
                "Adenuga",
                "James",
                "Computer Engineering",
                "Comp Eng Department",
                75.5,
                25, 
                "Male");
            students.Add(student1);


            Student student2 = new Student(
                "Bimpe",
                "Ajayi",
                "Omolola",
                "Arts & Culture",
                "Arts Department",
                65,
                19,
                "Female");
                students.Add(student2);
            
            Student student3 = new Student(
                "Ashanti",
                "Olayemi",
                "Omolola",
                "Accountancy",
                "Business Admin Department",
                95.5,
                27,
                "Female");
            students.Add(student3);
            
            Student student4 = new Student(
                "Olabode",
                "Ajagun",
                "Olawale",
                "Mechanical Engineering",
                "Mechanical Engineering Department",
                97,
                25,
                "Male");
            students.Add(student4);

            PrintStudentsInfo(students, student => student.gender.StartsWith("F"));



            static void PrintStudentsInfo(List <Student> students, myDelegate filter)
            {
                foreach (var student in students)
                {
                    if (filter(student))
                    {
                        
                        Console.WriteLine(student);
                    }
                }
            }
            
        }
        
       
    }
    
   
}