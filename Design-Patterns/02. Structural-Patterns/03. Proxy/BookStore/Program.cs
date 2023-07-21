namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (IBook book = new BookStoreProxy())
            {
                // get first page
                Page page1 = book.GetPage(1);
                Console.WriteLine(page1.Text);

                // get second page
                Page page2 = book.GetPage(2);
                Console.WriteLine(page2.Text);

                // go back to the first page
                page1 = book.GetPage(1);
                Console.WriteLine(page1.Text);
            }

            Console.Read();
        }
    }
}