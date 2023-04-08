namespace ExceptionValidationRule
{
    public interface IDataErrorInfo
    {
        string Error { get; }

        string this[string columnName] { get; }
    }
}
