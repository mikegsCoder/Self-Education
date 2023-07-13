namespace Builder
{
    public class Product
    {
        private List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Parts:");

            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
