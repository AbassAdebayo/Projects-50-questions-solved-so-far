using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class StudentController: Controller
    {
        public static List<Student> Students = new List<Student>()
        {
            new Student
            {
                Id = 1,
                Age = 20,
                Class = "100 Level",
                Name = "Aderonke"
            },
            
            new Student
            {
                Id =2,
            Age = 22,
            Class = "200 Level",
            Name = "Alabi Boluwatife"
            },
            
             
            new Student
            {
                Id =3,
                Age = 18,
                Class = "100 Level",
                Name = "Olawale Adeola"
            },
            
            new Student
            {
            Id =4,
            Age = 22,
            Class = "400 Level",
            Name = "Aniegbe Joseph"
            },
            
            new Student
            {
            Id =5,
            Age = 27,
            Class = "400 Level",
            Name = "Adebayo Abass"
        }
            
        };
        public IActionResult List()
        {
            return View(Students);
        }
        
          public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var student = Students.Where(n => n.Id == id).FirstOrDefault();
            return View(student);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            Students.Add(student);
            return RedirectToAction("List");
        }
       [HttpPost] 
        public IActionResult Update(Student student)
        {
            var studentUpdate = new Student
            {
                Name = student.Name,
                Age = student.Age,
                Class = student.Class
            };
            Students.Add(studentUpdate);
            return RedirectToAction("List");
        }
        
    }
}