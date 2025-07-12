using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Data
{
    public static class DataRepository
    {
        public static List<Author> Authors { get; set; } = new List<Author>
        {
            new Author { Id = 1, FirstName = "Victor", LastName = "Hugo", DateOfBirth = new DateTime(1802, 2, 26) },
            new Author { Id = 2, FirstName = "Gabriel", LastName = "García Márquez", DateOfBirth = new DateTime(1927, 3, 6) },
            new Author { Id = 3, FirstName = "Sabahattin", LastName = "Ali", DateOfBirth = new DateTime(1907, 2, 25) },
            new Author { Id = 4, FirstName = "George", LastName = "Orwell", DateOfBirth = new DateTime(1903, 6, 25) },
            new Author { Id = 5, FirstName = "Fyodor", LastName = "Dostoyevski", DateOfBirth = new DateTime(1821, 11, 11) },
            new Author { Id = 6, FirstName = "Oğuz", LastName = "Atay", DateOfBirth = new DateTime(1934, 10, 12) },
            new Author { Id = 7, FirstName = "Paulo", LastName = "Coelho", DateOfBirth = new DateTime(1947, 8, 24) },
            new Author { Id = 8, FirstName = "Yaşar", LastName = "Kemal", DateOfBirth = new DateTime(1923, 10, 6) },
            new Author { Id = 9, FirstName = "Mustafa Kemal", LastName = "Atatürk", DateOfBirth = new DateTime(1881, 5, 19) }
        };

        public static List<Book> Books { get; set; } = new List<Book>
        {
            new Book { Id = 1, Title = "Sefiller", AuthorId = 1, Genre = "Roman", PublishDate = new DateTime(1862, 1, 1), ISBN = "123456789", CopiesAvailable = 5 },
            new Book { Id = 2, Title = "Kırmızı Pazartesi", AuthorId = 2, Genre = "Polisiye", PublishDate = new DateTime(1981, 3, 15), ISBN = "987654321", CopiesAvailable = 3 },
            new Book { Id = 3, Title = "Kürk Mantolu Madonna", AuthorId = 3, Genre = "Roman", PublishDate = new DateTime(1943, 1, 1), ISBN = "9789753638029", CopiesAvailable = 4 },
            new Book { Id = 4, Title = "1984", AuthorId = 4, Genre = "Distopya", PublishDate = new DateTime(1949, 6, 8), ISBN = "9780451524935", CopiesAvailable = 6 },
            new Book { Id = 5, Title = "Suç ve Ceza", AuthorId = 5, Genre = "Klasik", PublishDate = new DateTime(1866, 1, 1), ISBN = "9786053609973", CopiesAvailable = 7 },
            new Book { Id = 6, Title = "Hayvan Çiftliği", AuthorId = 4, Genre = "Siyasi Alegori", PublishDate = new DateTime(1945, 8, 17), ISBN = "9789750718533", CopiesAvailable = 5 },
            new Book { Id = 7, Title = "Tutunamayanlar", AuthorId = 6, Genre = "Roman", PublishDate = new DateTime(1971, 1, 1), ISBN = "9789754700114", CopiesAvailable = 2 },
            new Book { Id = 8, Title = "Simyacı", AuthorId = 7, Genre = "Roman", PublishDate = new DateTime(1988, 1, 1), ISBN = "9780061122415", CopiesAvailable = 8 },
            new Book { Id = 9, Title = "İnce Memed", AuthorId = 8, Genre = "Roman", PublishDate = new DateTime(1955, 1, 1), ISBN = "9789750800016", CopiesAvailable = 3 },
            new Book { Id = 10, Title = "Nutuk", AuthorId = 9, Genre = "Tarih", PublishDate = new DateTime(1927, 10, 15), ISBN = "9789751000002", CopiesAvailable = 10 }
        };
    }
}
