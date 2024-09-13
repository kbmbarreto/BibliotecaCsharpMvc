using BibliotecaCsharpMvc.Data;
using BibliotecaCsharpMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaCsharpMvc.Controllers
{
    public class BookController : Controller
    {
        readonly private ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<BookModel> books = _db.Books;
            return View(books);
        }

        public IActionResult InsertBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Add(bookModel);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}