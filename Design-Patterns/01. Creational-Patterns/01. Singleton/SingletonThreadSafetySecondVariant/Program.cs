namespace SingletonThreadSafetySecondVariant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                Singleton singleton1 = Singleton.GetInstance();
                Console.WriteLine(singleton1.Date);
            }).Start();

            Singleton singleton2 = Singleton.GetInstance();
            Console.WriteLine(singleton2.Date);
        }
    }
}