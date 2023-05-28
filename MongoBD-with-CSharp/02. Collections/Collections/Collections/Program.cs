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

            int input = 0;

            while (input != 7)
            {
                Menu();
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        try
                        {
                            db.GetCollections();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 2:
                        try
                        {
                            db.GetCollectionNames();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 3:
                       
                        break;
                    case 4:
                       
                        break;
                    case 5:
                       
                        break;
                    case 6:
                       
                        break;
                    default:
                        break;
                }
            }
        }

        private static void Menu()
        {
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("1. Get collections");
            Console.WriteLine("2. Get collection names");
            Console.WriteLine("3. Create collection");
            Console.WriteLine("4. Rename collection");
            Console.WriteLine("5. Drop collection");
            Console.WriteLine("6. Get collection");
            Console.WriteLine("7. Exit");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("Enter your choise:");
        }
    }
}