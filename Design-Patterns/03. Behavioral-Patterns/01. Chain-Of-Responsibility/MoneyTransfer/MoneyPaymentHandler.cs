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
