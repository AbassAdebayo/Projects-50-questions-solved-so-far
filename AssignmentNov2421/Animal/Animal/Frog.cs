namespace Animal
{
    public class Frog:Animal
    {
        public Frog(string name, int age): base(name,age)
        {
           
        }

        public override string Sound()
        {
            return $"hoorhor";
        }
    }
}