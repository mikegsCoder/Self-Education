namespace BookLibrary
{
    public class Library : IBookNumerable
    {
        private Book[] books;

        public Library()
        {
            books = new Book[]
            {
                new Book{Name="C# development"},
                new Book {Name="JS development"},
                new Book {Name="Design patterns"}
            };
        }

        public int Count
        {
            get { return books.Length; }
        }

        public Book this[int index]
        {
            get { return books[index]; }
        }

        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
}
