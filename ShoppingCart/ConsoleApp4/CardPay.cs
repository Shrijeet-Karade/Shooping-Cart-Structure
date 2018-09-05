using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class CardPayment:Cart,IPaymentDetails
    {
        void SetDetails()
        {

        }

        void IPaymentDetails.SetDetails()
        {
            throw new NotImplementedException();
        }

        public void Pay()
        {
            Console.WriteLine(  "payment success through card");
        }
    }
}
