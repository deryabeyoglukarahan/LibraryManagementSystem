using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Data;
using System;
using System.Linq;

namespace LibraryManagementSystem.Controllers
{
    public class AuthorController : Controller
    {
        // LIST – Yazarları listele
        public IActionResult List()
        {
            return View(DataRepository.Authors);
        }

        // DETAILS – Belirli bir yazarın detayını göster
        public IActionResult Details(int id)
        {
            var author = DataRepository.Authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound();
            return View(author);
        }

        // CREATE – Yeni yazar formu (GET)
        public IActionResult Create()
        {
            return View();
        }

        // CREATE – Yeni yazar kaydetme (POST)
        [HttpPost]
        public IActionResult Create(Author author)
        {
            author.Id = DataRepository.Authors.Max(a => a.Id) + 1;
            DataRepository.Authors.Add(author);

            // Yeni yazar eklendikten sonra kitap ekleme sayfasına yönlendir
            return RedirectToAction("Create", "Book");
        }

        // EDIT – Var olan yazarı düzenleme formu (GET)
        public IActionResult Edit(int id)
        {
            var author = DataRepository.Authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound();
            return View(author);
        }

        // EDIT – Yazarı güncelleme (POST)
        [HttpPost]
        public IActionResult Edit(Author updatedAuthor)
        {
            var author = DataRepository.Authors.FirstOrDefault(a => a.Id == updatedAuthor.Id);
            if (author == null) return NotFound();

            author.FirstName = updatedAuthor.FirstName;
            author.LastName = updatedAuthor.LastName;
            author.DateOfBirth = updatedAuthor.DateOfBirth;

            return RedirectToAction("List");
        }

        // DELETE – Yazar silme onayı (GET)
        public IActionResult Delete(int id)
        {
            var author = DataRepository.Authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound();
            return View(author);
        }

        // DELETE – Yazar silme işlemi (POST)
        [HttpPost]
        public IActionResult Delete(Author author)
        {
            var existing = DataRepository.Authors.FirstOrDefault(a => a.Id == author.Id);
            if (existing == null) return NotFound();

            DataRepository.Authors.Remove(existing);
            return RedirectToAction("List");
        }
    }
}
