using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemStockOrder
{
    public class Order
    {
        public Item Item { get; set; }
        public DateTime Created { get; set; }
    }
}
