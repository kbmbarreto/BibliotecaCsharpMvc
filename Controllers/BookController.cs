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

        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            BookModel book = _db.Books.FirstOrDefault(x => x.Id == id);

            if (book == null) 
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost]
        public IActionResult UpdateBook(BookModel book) 
        {
            if (ModelState.IsValid)
            {
                _db.Books.Update(book);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(book);
        }

        [HttpGet]
        public IActionResult Delete(int? id) 
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            BookModel book = _db.Books.FirstOrDefault(x => x.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost]
        public IActionResult DeleteBook(BookModel book)
        {
            if (book == null) 
            {
                return NotFound();
            }
            _db.Books.Remove(book);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}