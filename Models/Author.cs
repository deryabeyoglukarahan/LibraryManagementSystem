using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Models
{
    public class Author
    {
        public int Id { get; set; }                 // Yazarın benzersiz kimliği
        public string FirstName { get; set; }       // Yazarın adı
        public string LastName { get; set; }        // Yazarın soyadı
        public DateTime DateOfBirth { get; set; }   // Yazarın doğum tarihi

        // Navigation Property – Yazarın kitapları
        public List<Book> Books { get; set; }
    }
}
