namespace Animal
{
    public class Tomcat: Animal
    {
        public Tomcat(string name, int age): base(name,age)
        {
           
        }

        public override string Sound()
        {
            return $"Coo Coo";
        }
    }
}