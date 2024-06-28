using Contactes.Domain.Entities;
using Contactes.Web.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Contactes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AppointmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetContacts")]
        public IEnumerable<Contact> Get()
        {
            var contactsFromDb = _context.Contacts.ToList();
            return contactsFromDb;
        }

        [HttpGet("{id}", Name = "GetContact")]
        public ActionResult<Contact> Get(int id)
        {
            var contactFromDb = _context.Contacts.FirstOrDefault(p => p.Id == id);
            if (contactFromDb == null)
            {
                return NotFound("Contact not found");
            }
            return Ok(contactFromDb);
        }

        [HttpPost(Name = "CreateContact")]
        public async Task<IActionResult> Create([FromBody] Contact model)
        {
            if (model == null)
            {
                return BadRequest("Contact data is null");
            }

            bool emailExists = await _context.Contacts
                .AnyAsync(c => c.Email == model.Email);
            if (emailExists)
            {
                return BadRequest("This email is already in use");
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
                return CreatedAtRoute("GetContact", new { id = contactDb.Id }, contactDb);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}", Name = "UpdateContact")]
        public async Task<IActionResult> Update(int id, [FromBody] Contact model)
        {
            if (model == null || id != model.Id)
            {
                return BadRequest("Contact data is invalid");
            }

            var contactFromDb = await _context.Contacts.FindAsync(id);
            if (contactFromDb == null)
            {
                return NotFound("Contact not found");
            }

            if (await _context.Contacts.AnyAsync(c => c.Email == model.Email && c.Id != id))
            {
                return BadRequest("This email is already in use by another contact");
            }

            if (ModelState.IsValid)
            {
                contactFromDb.Email = model.Email;
                contactFromDb.PhoneNumber = model.PhoneNumber;
                contactFromDb.Name = model.Name;

                _context.Contacts.Update(contactFromDb);
                await _context.SaveChangesAsync();
                return Ok(contactFromDb);
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}", Name = "DeleteContact")]
        public async Task<IActionResult> Delete(int id)
        {
            var contactFromDb = await _context.Contacts.FindAsync(id);
            if (contactFromDb == null)
            {
                return NotFound("Contact not found");
            }

            _context.Contacts.Remove(contactFromDb);
            await _context.SaveChangesAsync();
            return Ok("Contact Deleted");
        }
    }
}
