using System;

namespace Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            Double radius_pie = 3.142;
            
            Console.Write("enter the value of radius: ");
            Double radius=Convert.ToDouble(Console.ReadLine());
            
            Console.Write("enter the value of length: ");
            Double length=Convert.ToDouble(Console.ReadLine());
            
            Double area = radius * radius_pie;
            Double volume = area * length;
            
            Console.Write($"the area of a cylinder = {area}");
            Console.Write($"the volume of a cylinder = {volume}");
        }
    }
}