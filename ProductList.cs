using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDayAssesment
{
    internal class ProductList
    {
        public static void Main()
        {
            string[][] products = new string[4][];
            products[0] = new string[] { "List", "Product Catagory", "No of Items" };
            products[1] = new string[] { "a.", "Buscuits","","There are 4 items"};
            products[2] = new string[] { "b.", "Chocolates","", "There are 5 items"};
            products[3] = new string[] { "c.", "Drinks", "","", "There are 6 items" };
            for (int i = 0; i < products.Length; i++) 
            {
                for (int j = 0; j < products[i].Length; j++)
                {
                    Console.Write(products[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
