namespace SingletonThreadSafetySecondVariant
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        public string Date { get; private set; }

        private Singleton()
        {
            Date = DateTime.Now.TimeOfDay.ToString();
        }

        public static Singleton GetInstance()
        {
            return instance;
        }
    }
}
