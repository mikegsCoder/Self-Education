using Microsoft.EntityFrameworkCore;

namespace BookStore
{
    public class PageContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
    }
}
