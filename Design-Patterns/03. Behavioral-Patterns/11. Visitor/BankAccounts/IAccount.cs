namespace BankAccounts
{
    public interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}
