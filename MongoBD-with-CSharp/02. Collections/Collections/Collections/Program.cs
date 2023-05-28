using MongoDB.Driver.Core.Operations;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string database = "test2";

            DatabaseOperations db = new DatabaseOperations(database);
        }
    }
}