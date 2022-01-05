using System;

namespace Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var score1 = new Score()
            {
                Name = "Ola",
                Mark = 70



            };

            var score2 = new Score()
            {
                Name = "Bayo",
                Mark = 90
            };

           Console.Write(score1);
            
           
            

        }
        

    }

    class Score
    {
        public string Name { get; set; }
        public int Mark { get; set; }
        

        public static Score operator +(Score a, Score b)
        {
            return new Score
            {
                Name = a.Name + b.Name,
                Mark = a.Mark+ b.Mark
            };
        }

        public static Score operator ++(Score a)
        {
            a.Mark += 5;
            return a;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nScore: {Mark}";
        }
    }
}