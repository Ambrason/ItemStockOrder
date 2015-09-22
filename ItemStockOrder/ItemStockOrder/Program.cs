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
            //var stock = new Stock();
            //stock.Items.Add(new Item() { Name = "", ArticleNum = "0", Price = 0, Circumcised = true });

            //Console.WriteLine("Number of items in stock: " + stock.NumberOfItems);
            //Console.ReadKey();

            while (true)
            {
                Console.WriteLine("Enter first number");
                float n1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                float n2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter operator");
                char o = char.Parse(Console.ReadLine());

                float n3;

                /*
                switch (o)
                {
                    case '+':
                        n3 = n1 + n2;
                        break;
                    case '-':
                        n3 = n1 - n2;
                        break;
                    case '*':
                        n3 = n1 * n2;
                        break;
                    case '/':
                        if (n2 != 0)
                        {
                            n3 = n1 / n2;
                        }
                        else
                        {
                            break;
                        }
                        break;

                }*/

                if (o == '+')
                {
                    n3 = n1 + n2;
                }
                else if (o == '-')
                {
                    n3 = n1 - n2;
                }
                else if (o == '*')
                {
                    n3 = n1 * n2;
                }
                else if (o == '/')
                {
                    if (n2 != 0)
                        n3 = n1 / n2;
                    else
                        return;
                }
                else
                    return;

                //var n3 = o == '+' ? n1 + n2 : o == '-' ? n1 - n2 : o == '*' ? n1 * n2 : o == '/' ? n2 == 0 ? 0 : n1 / n2 : 0;
                Console.WriteLine(n3);
            }
        }
    }
}
