using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   public class Program:SelectType
    {
       public static void Main(string[] args)
        {
            string desc = Console.ReadLine();
            IProduct prod = GetProduct(desc);
            prod.GetTypeofProduct();
            prod.Book();
            prod.Save();
        }

        private static IProduct GetProduct(string desc)
        {
            throw new NotImplementedException();
        }
    }
    public class SelectType
    {
        private IProduct GetProduct(string desc)
        {

            return new CarProduct();
        }
    }
}
