using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemStockOrder
{
    class Stock
    {
        public string Name { get; set; }
        public ICollection<Item> Items { get; set; }
        public int NumberOfItems { get { return Items.Count(); } }

        public Stock()
        {
            Items = new List<Item>();
        }

        public Stock(ICollection<Item> items)
        {
            Items = items;
        }
    }
}
