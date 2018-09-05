using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class CarProduct:IProduct
    {
        public string GetTypeofProduct()
        {
            return "CAR";
        }
        public void Book()
        {
            Console.WriteLine("booking car product");
        }
        public void Save()
        {
            Console.WriteLine("saving car product");
        }
    }
}
