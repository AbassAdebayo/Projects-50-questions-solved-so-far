using System;
using System.Collections.Generic;

namespace Inventory
{
    public class GoodsManager
    {
        private List<GoodsManager> items = new List<GoodsManager>();


        public void CreateItems()
        {
            Console.WriteLine("Enter item to create: ");
            string itemName = Console.ReadLine();
            
            Console.WriteLine();
        }
    }
   
    
}