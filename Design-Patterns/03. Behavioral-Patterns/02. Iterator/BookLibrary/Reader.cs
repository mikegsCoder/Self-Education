﻿namespace BookLibrary
{
    public class Reader
    {
        public void SeeBooks(Library library)
        {
            IBookIterator iterator = library.CreateNumerator();

            while (iterator.HasNext())
            {
                Book book = iterator.Next();

                Console.WriteLine(book.Name);
            }
        }
    }
}
