using Bookstore.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Web.Context
{
    public class BookDataContext: DbContext
    {
        public BookDataContext(DbContextOptions<BookDataContext> options)
            : base(options)
        {
        }

       public DbSet<Book> Books { get; set; }
    }
}
