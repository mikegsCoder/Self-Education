using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class BookStoreProxy : IBook
    {
        List<Page> pages;
        BookStore bookStore;

        public BookStoreProxy()
        {
            pages = new List<Page>();
        }

        public Page GetPage(int number)
        {
            Page page = pages.FirstOrDefault(p => p.Number == number);

            if (page == null)
            {
                if (bookStore == null)
                {
                    bookStore = new BookStore();
                }

                page = bookStore.GetPage(number);

                pages.Add(page);
            }

            return page;
        }

        public void Dispose()
        {
            if (bookStore != null)
            {
                bookStore.Dispose();
            }
        }
    }
}
