namespace MongoDbApp
{
    public class Program
    {

        public static void Main(string[] args)
        {
            DatabaseOperations db = new DatabaseOperations();

            int input = 0;

            while (input != 5)
            {
                Menu();
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        try
                        {
                            db.GetDatabases();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 2:
                        try
                        {
                            db.GetDatabaseNames();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("Enter databse name to get: ");
                            string name = Console.ReadLine().Trim();

                            db.GetDatabase(name);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine("Enter databse name to drop: ");
                            string name = Console.ReadLine().Trim();

                            db.DropDatabase(name);
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
            Console.WriteLine("1. Get databases");
            Console.WriteLine("2. Get datase names");
            Console.WriteLine("3. Get database by name");
            Console.WriteLine("4. Drop database");
            Console.WriteLine("5. Exit");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("Enter your choise:");
        }
    }
}