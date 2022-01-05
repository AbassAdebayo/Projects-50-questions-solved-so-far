using System;

namespace Inventory
{
    public class SalesInventories
    {
        public bool Sales = true;
        public string ItemName { get; private set; }
        public int QuantitySold { get; private set; }
        public  double PriceBought { get; private set; }
        public string ItemSKU { get; private set; }
        public double PriceSold { get; private set; }
        public double totalSales;

        public SalesInventories(string itemName, int quantitySold, double priceBought, string itemSku, double priceSold)
        {
            ItemName = itemName;
            QuantitySold = quantitySold;
            PriceBought = priceBought;
            ItemSKU = itemSku;
            PriceSold = priceSold;
        }

        public double TotalSalesForEachItem(double totalSales)
        {
            totalSales = QuantitySold * PriceSold;

            return totalSales;
        }
       

        public override string ToString()
        {
            return $"Item: {ItemName}, Quantity Sold: {QuantitySold}qt, Price bought at Market: " +
                   $"#{PriceBought}, ItemSKU: {ItemSKU}, Price of Item(s) sold: #{PriceSold} and Total sales of {ItemName} sold is #{TotalSalesForEachItem(totalSales)}";
        }
    }
}