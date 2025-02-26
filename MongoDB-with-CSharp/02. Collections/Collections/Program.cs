﻿namespace Collections
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
                        try
                        {
                            Console.WriteLine("Enter new collection name: ");
                            string name = Console.ReadLine().Trim();

                            db.CreateCollection(name);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine("Enter old collection name: ");
                            string oldName = Console.ReadLine().Trim();

                            Console.WriteLine("Enter new collection name: ");
                            string newName = Console.ReadLine().Trim();

                            db.RenameCollection(oldName, newName);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 5:
                        try
                        {
                            Console.WriteLine("Enter collection name to drop: ");
                            string name = Console.ReadLine().Trim();

                            db.DropCollection(name);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 6:
                        try
                        {
                            Console.WriteLine("Enter collection name to get: ");
                            string name = Console.ReadLine().Trim();

                            var myCollection = db.GetCollection(name);

                            Console.WriteLine(myCollection.ToString());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
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