using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   public class Program
    {
       public static void Main(string[] args)
        {
            ProductDetails obj = new ProductDetails();
            string desc = Console.ReadLine();
            IProduct prod = obj.GetProduct(desc);
            prod.GetTypeofProduct();
            prod.Book();
            prod.Save();
            Console.ReadKey();
        }

      
    }
    
}
