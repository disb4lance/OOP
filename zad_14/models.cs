using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_14
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }

    // Book.cs
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
