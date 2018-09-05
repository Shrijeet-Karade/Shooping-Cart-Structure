using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    class CashPayment : Cart,IPaymentDetails
    {
        public void SetDetails()
        {
            throw new NotImplementedException();
        }
        public void Pay()
        {
            Console.WriteLine("payment success through card");
        }

    }
}
