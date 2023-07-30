namespace MoneyTransfer
{
    public class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
            {
                Console.WriteLine("Executing PayPal transfer.");
            }
            else if (Successor != null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}
