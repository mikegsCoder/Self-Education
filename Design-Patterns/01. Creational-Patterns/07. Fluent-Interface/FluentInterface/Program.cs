namespace FluentInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FluentEmployee fluentEmployee = new FluentEmployee();

            fluentEmployee.NameOfTheEmployee("Peter Petrov")
            .Born("10/11/1990")
            .SetDepartment("IT")
            .SetAddress("Varna, Bulgaria");
        }
    }
}