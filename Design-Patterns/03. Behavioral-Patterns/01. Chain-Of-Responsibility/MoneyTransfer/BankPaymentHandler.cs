namespace MoneyTransfer
{
    public class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
            {
                Console.WriteLine("Executing bank transfer.");
            }
            else if (Successor != null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}
