using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Shopping:Cart
    {
        static void Main(string[] args)
        {
            
            AddItems();
            // maintaining array of objects here
           
            RemoveItems();
            // remove Cart items
            CheckOut();
        }
        static void AddItems ()
        {
            string itemName;
            Cart obj = new Cart();
            //add to lists of objects
        }
       static void RemoveItems()
        {
            Cart obj = new Cart("remove");
            // remove from list of objects
        }
        static void CheckOut()
        {
            // cash 
            CashPayment obj = new CashPayment();
            obj.Pay();
            Console.ReadKey();
            // card
            CardPayment object2 = new CardPayment();
            obj.Pay();
            Console.ReadKey();

        }
        
    }
}
