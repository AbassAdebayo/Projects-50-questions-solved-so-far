namespace Animal
{
    public class Cat:Animal
    
    {
        public Cat(string name, int age): base(name,age)
        {
           
        }

        public override string Sound()
        {
            return $"Meuw";
        }
    }
}