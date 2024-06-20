using Contacte.API;
using Contactes.Domain.Entities;
using Contactes.Web.Models;
using Contactes.Web.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Contactes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController: ControllerBase
    {
        private readonly ApplicationDbContext _context;
        
        public ContactsController(ApplicationDbContext context)
        { 
            _context = context;
        }

        [HttpGet(Name = "GetContacts")]
        public IEnumerable<Contact> Get()
        {
             var contactsFromDb = _context.Contacts.ToList();
            return contactsFromDb;
        }

        //[HttpGet(Name = "GetContact")]
        //public Contact Get(int id)
        //{
        //    var contactFromDb = _context.Contacts.FirstOrDefault(p=>p.Id == id);
        //    return contactFromDb;
        //}

    
        //[HttpPost(Name = "CreateContact")] 
        //public async Task<IActionResult> Create([FromBody] Contact model)
        //{

        //    bool findedEmail = await _context.Contacts
        //        .AnyAsync(c => c.Email == model.Email);
        //    if (findedEmail) 
        //    { 
        //        return BadRequest("This email is already in use");
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        var contactDb = new Contact
        //        {
        //            Email = model.Email,
        //            PhoneNumber = model.PhoneNumber,
        //            Name = model.Name
        //        };

        //        _context.Contacts.Add(contactDb);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return Ok(model);
        //}
    }
}
