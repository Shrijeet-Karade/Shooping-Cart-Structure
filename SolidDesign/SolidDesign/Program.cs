using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cartObj = new Cart();
            cartObj.itemId = 1;
            cartObj.Item = new List<ItemDetails>();
            Inventory inventoryObj = new Inventory();
            FunctionsInsideCart cartOperationObject = new FunctionsInsideCart();
            List<ItemDetails> availableItems = inventoryObj.GetAllItems();
        }
    }
}
