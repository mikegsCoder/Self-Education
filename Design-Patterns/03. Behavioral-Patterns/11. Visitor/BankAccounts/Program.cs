﻿namespace BankAccounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var structure = new Bank();

            structure.Add(new Person { Name = "Ivan Ivanov", Number = "82184931" });
            structure.Add(new Company { Name = "Microsoft", RegNumber = "ewuir32141324", Number = "3424131445" });

            structure.Accept(new HtmlVisitor());
            structure.Accept(new XmlVisitor());

            Console.Read();
        }
    }
}