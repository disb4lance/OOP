using System;
using System.Linq;
using zad_14;

class Program
{
    static void Main(string[] args)
    {
        using (var db = new datacontext())
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            // Заполнение базы данных начальными данными
            var author1 = new Author { Name = "Author 1" };
            var author2 = new Author { Name = "Author 2" };

            db.Authors.Add(author1);
            db.Authors.Add(author2);

            db.Books.Add(new Book { Title = "Book 1", Author = author1 });
            db.Books.Add(new Book { Title = "Book 2", Author = author1 });
            db.Books.Add(new Book { Title = "Book 3", Author = author2 });

            db.SaveChanges();
        }

        using (var db = new datacontext())
        {
            var authors = db.Authors.ToList();
            foreach (var author in authors)
            {
                Console.WriteLine($"Author: {author.Name}");
                foreach (var book in author.Books)
                {
                    Console.WriteLine($"    Book: {book.Title}");
                }
            }
        }
    }
}