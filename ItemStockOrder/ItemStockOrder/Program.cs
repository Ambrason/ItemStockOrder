using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemStockOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();
            stock.Items.Add(new Item() { Name = "", ArticleNum = "0", Price = 0, Circumcised = true });

            Console.WriteLine("Number of items in stock: " + stock.NumberOfItems);
            Console.ReadKey();
        }
    }
}
