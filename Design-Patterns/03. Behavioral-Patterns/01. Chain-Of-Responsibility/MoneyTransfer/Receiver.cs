using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    public class Receiver
    {
        // bank transfer
        public bool BankTransfer { get; set; }

        // money transfers
        public bool MoneyTransfer { get; set; }

        // PayPal transfer
        public bool PayPalTransfer { get; set; }

        public Receiver(bool bt, bool mt, bool ppt)
        {
            BankTransfer = bt;
            MoneyTransfer = mt;
            PayPalTransfer = ppt;
        }
    }
}
