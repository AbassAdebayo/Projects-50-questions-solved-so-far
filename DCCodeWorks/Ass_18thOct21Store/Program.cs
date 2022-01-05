using System;

namespace Ass_18thOct21Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Store:");

            Console.Write("Enter the store name: ");
            string storename= Console.ReadLine();
            

            Console.Write("Enter the store address: ");
            string storeaddress=Console.ReadLine();
            

            Console.WriteLine("Items:");
            string item=Console.ReadLine();
            

            Console.Write("SKU: ");
            string SKU=Console.ReadLine();

            Console.Write("Quantity: ");
            int Quantity=Convert.ToInt32(Console.ReadLine());

            Console.Write("Price: ");
            int Price=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Store: ");
            Console.WriteLine($"Name: {storename}");
            Console.WriteLine($"Address: {storeaddress}");
            Console.WriteLine($"item: {item}");
            Console.WriteLine($"SKU: {SKU}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Price: {Price}");



        }
    }
}
