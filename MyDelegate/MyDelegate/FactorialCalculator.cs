using System.Numerics;

namespace MyDelegate
{
    public class FactorialCalculator
    {
        public BigInteger Facto(BigInteger num)
        {
            if (num==1)
            {
                return num;
            }
            else
            {
                return Facto(num - 1) * num;
            }
        }
    }
}