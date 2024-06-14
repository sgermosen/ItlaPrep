using Contactes.Web.Models;
using Contactes.Web.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Contactes.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var contactsFromDb = await _context.Contacts.ToListAsync();
            var contacts = new List<ContactModel>();
            foreach (var contact in contactsFromDb)
            {
                contacts.Add(new ContactModel
                {
                    Name = contact.Name,
                    PhoneNumber = contact.PhoneNumber,
                    Email = contact.Email,
                    Id = contact.Id
                });
            }
            var model = new HomeViewModel { Contacts = contacts, ContactHeader = "Lo Contato" };
            return View(model);
        }
        //public IActionResult Index()
        //{
        //   var contacts =    _context.Contacts.ToList()
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}