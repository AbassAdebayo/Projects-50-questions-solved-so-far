using System;

namespace TestOnDelegat
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string courseTitle { get; set; }
        public string department { get; set; }
        public double score { get; set; }
        public int age { get; set; }

        public string gender { get; set; }
        private double avgScore;
        
        
        

        public Student(string firstName,string lastName, 
            string middleName, string courseTitle, string department, double score, int age, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.courseTitle = courseTitle;
            this.department = department;
            this.score = score;
            this.age = age;
            this.gender = gender;

        }

        public double totalScore = 200;
        public double GetAverageScore(double avgScore)
        {
            avgScore = (score / totalScore) * 100;
            return avgScore;
        }

        public override string ToString()
        {
            if (gender.StartsWith("M"))
            {
                return $"Student: {lastName} {firstName} {middleName} of age {age} gender {gender} studying {courseTitle}" +
                       $" in department of {department} scored {score} and his average score is {GetAverageScore(avgScore)}";
            }
            else if (gender.StartsWith("F"))
            {
                return $"Student: {lastName} {firstName} {middleName} of age {age} gender {gender} studying {courseTitle}" +
                       $" in department of {department} scored {score} and her average score is {GetAverageScore(avgScore)}";
            }


            return null;

        }
    }
    
   
}