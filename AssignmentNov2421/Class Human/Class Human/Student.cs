using System;

namespace Class_Human
{
    public class Student: Human
    {
        double Mark;

        public Student(string firstName, string lastName, double mark): base(firstName,lastName)
        {
            Mark = mark;
        }
        
    }
    
}