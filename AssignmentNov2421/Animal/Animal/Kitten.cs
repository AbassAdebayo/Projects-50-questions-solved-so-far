namespace Animal
{
    public class Kitten:Animal
    {
        public Kitten(string name, int age): base(name,age)
        {
           
        }

        public override string Sound()
        {
            return $"Meeeew";
        }
    }
}