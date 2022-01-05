using System;

namespace Class_Human
{
    public class Human
    {
        protected string FirstName;
        protected string LastName;
        

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }
        
        public string GetFirstName()
        {
            return FirstName;
        }
        
        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }
        
        public string GetLastName()
        {
            return LastName;
        }
        
    }
}