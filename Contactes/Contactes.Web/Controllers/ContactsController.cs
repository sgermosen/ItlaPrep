using Contactes.Domain.Entities;
using Contactes.Web.Models;
using Contactes.Web.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Contactes.Web.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactsController(ApplicationDbContext context)
        {
            _context = context;
        }

        //[HttpGet] 
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contacts.ToListAsync());
        }

        //  [HttpGet]
        public IActionResult Create()
        {
            return View("Add");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateContactViewModel model)
        {

            bool findedEmail = await _context.Contacts
                .AnyAsync(c => c.Email == model.Email);
            if (findedEmail)// == true)
            {
                ModelState.AddModelError("Email", "This email is already in use");
                return View(model);
            }

            if (ModelState.IsValid)
            {
                var contactDb = new Contact
                {
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    Name = model.Name
                };

                _context.Contacts.Add(contactDb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, ContactModel model)
        {
            id = 9999999999;
            if (id != model.Id)
            {
                return NotFound();
            }

            var contactByEmail = await _context.Contacts.AsNoTracking()
                .FirstOrDefaultAsync(c => c.Email == model.Email);
            if (contactByEmail != null)
            {
                if (contactByEmail.Id != model.Id)
                {
                    ModelState.AddModelError("Email", "This email is already in use");
                    return View(model);
                }
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var contactFromDb = await _context.Contacts
                .FirstOrDefaultAsync(c => c.Email == model.Email);


                    contactFromDb.Email = model.Email;
                    contactFromDb.PhoneNumber = model.PhoneNumber;
                    contactFromDb.Name = model.Name;


                    _context.Contacts.Update(contactFromDb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int? idToDelete)
        {
            if (idToDelete == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts
                .FirstOrDefaultAsync(m => m.Id == idToDelete);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactExists(int id)
        {
            return _context.Contacts.Any(e => e.Id == id);
        }
    }
}
