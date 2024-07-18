using Bookstore.Web.Context;
using Bookstore.Web.Models;
using Bookstore.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Web.Controllers
{
    public class BooksController : Controller
    {
       // private readonly BookstoreAdoService _bookstoreAdoService;
        private readonly BookDataContext _context;
        // public BooksController( BookstoreAdoService bookstoreAdoService)
        public BooksController(BookDataContext context)
        {
            //_bookstoreAdoService = bookstoreAdoService;
            _context = context;
        }
        public IActionResult Index()
        {
            //var books = _bookstoreAdoService.GetAll(); 
            var books = _context.Books.ToList();
            return View(books);
        }
        public IActionResult Create()
        { 
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book model)
        {
            // _bookstoreAdoService.Add(model);
            _context.Books.Add(model);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
