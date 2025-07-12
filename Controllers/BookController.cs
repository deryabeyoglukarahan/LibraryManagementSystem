using LibraryManagementSystem.Models;
using LibraryManagementSystem.ViewModels;
using LibraryManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LibraryManagementSystem.Controllers
{
    public class BookController : Controller
    {
        // LIST – Kitapları listele
        public IActionResult List()
        {
            var viewModelList = DataRepository.Books.Select(book => new BookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Genre = book.Genre,
                PublishDate = book.PublishDate,
                ISBN = book.ISBN,
                CopiesAvailable = book.CopiesAvailable,
                AuthorFullName = DataRepository.Authors.FirstOrDefault(a => a.Id == book.AuthorId) is Author author
                    ? $"{author.FirstName} {author.LastName}"
                    : "Bilinmiyor"
            }).ToList();

            return View(viewModelList);
        }

        // DETAILS – Kitap detaylarını göster
        public IActionResult Details(int id)
        {
            var book = DataRepository.Books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();

            var author = DataRepository.Authors.FirstOrDefault(a => a.Id == book.AuthorId);

            var viewModel = new BookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Genre = book.Genre,
                PublishDate = book.PublishDate,
                ISBN = book.ISBN,
                CopiesAvailable = book.CopiesAvailable,
                AuthorFullName = author != null ? $"{author.FirstName} {author.LastName}" : "Bilinmiyor"
            };

            return View(viewModel);
        }

        // CREATE (GET)
        public IActionResult Create()
        {
            ViewBag.Authors = DataRepository.Authors.Select(a => new
            {
                Id = a.Id,
                FullName = $"{a.FirstName} {a.LastName}"
            }).ToList();

            return View();
        }

        // CREATE (POST)
        [HttpPost]
        public IActionResult Create(Book book)
        {
            book.Id = DataRepository.Books.Any() ? DataRepository.Books.Max(b => b.Id) + 1 : 1;
            DataRepository.Books.Add(book);
            return RedirectToAction("List");
        }

        // EDIT (GET)
        public IActionResult Edit(int id)
        {
            var book = DataRepository.Books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();

            ViewBag.Authors = DataRepository.Authors.Select(a => new
            {
                Id = a.Id,
                FullName = $"{a.FirstName} {a.LastName}"
            }).ToList();

            return View(book);
        }

        // EDIT (POST)
        [HttpPost]
        public IActionResult Edit(Book updatedBook)
        {
            var book = DataRepository.Books.FirstOrDefault(b => b.Id == updatedBook.Id);
            if (book == null) return NotFound();

            book.Title = updatedBook.Title;
            book.AuthorId = updatedBook.AuthorId;
            book.Genre = updatedBook.Genre;
            book.PublishDate = updatedBook.PublishDate;
            book.ISBN = updatedBook.ISBN;
            book.CopiesAvailable = updatedBook.CopiesAvailable;

            return RedirectToAction("List");
        }

        // DELETE (GET)
        public IActionResult Delete(int id)
        {
            var book = DataRepository.Books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();
            return View(book);
        }

        // DELETE (POST)
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = DataRepository.Books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();

            DataRepository.Books.Remove(book);
            return RedirectToAction("List");
        }
    }
}
