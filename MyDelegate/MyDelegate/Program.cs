using System;

delegate int NumberOperate(int num);

namespace MyDelegate
{
    class Program
    {
        private static int num = 10;
        static void Main(string[] args)
        {
            NumberOperate numberOperateAdd = new NumberOperate(AddNum);
            NumberOperate numberOperateMult = new NumberOperate(MultNum);

            AddNum(25);
            Console.WriteLine(GetNum());
            MultNum(5);
            Console.WriteLine(GetNum());

            FactorialCalculator factorial = new FactorialCalculator();
            
            Console.WriteLine("Enter a number");
            int factoNum = int.Parse(Console.ReadLine());
            Console.Write($"The factorial of {factoNum} = {(factorial.Facto(factoNum))}");
        }

        public static int AddNum(int a)
        {
            num += a;
            return num;
        }

        public static int MultNum(int b)
        {
            num *= b;
            return num;
        }

        public static int GetNum()
        {
            return num;
        }
    }
}