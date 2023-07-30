using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    public class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
            {
                Console.WriteLine("Executing WesternUnion transfer.");
            }
            else if (Successor != null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}
