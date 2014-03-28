using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using SPA_Cloud_Sample.Models;
using SPA_Cloud_Sample.Common;

namespace SPA_Cloud_Sample.Controllers
{
    public class ContactsController : ApiController
    {
        private readonly IContactRepository _repository;
        public ContactsController(IContactRepository repo)
        {
            _repository = repo;
        }

        [ResponseType(typeof(Contact))]
        public async Task<IEnumerable<Contact>> GetContacts()
        {
            return await _repository.GetAll();
        }

        // GET api/Contacts/5
        [ResponseType(typeof(Contact))]
        public async Task<IHttpActionResult> GetContact(int id)
        {
            Contact contact = await _repository.GetById(id);
            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        // PUT api/Contacts/5
        public async Task<IHttpActionResult> PutContact(int id, Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != contact.ContactId)
            {
                return BadRequest();
            }

            try
            {
                await _repository.Update(contact);
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!ContactExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/Contacts
        [ResponseType(typeof(Contact))]
        public async Task<IHttpActionResult> PostContact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _repository.Add(contact);


            return CreatedAtRoute("DefaultApi", new { id = contact.ContactId }, contact);
        }

        // DELETE api/Contacts/5
        [ResponseType(typeof(Contact))]
        public async Task<IHttpActionResult> DeleteContact(int id)
        {
            Contact contact = await _repository.GetById(id);
            if (contact == null)
            {
                return NotFound();
            }


            await _repository.Remove(id);

            return Ok(contact);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repository.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ContactExists(int id)
        {

            var contact = _repository.GetById(id);
            return contact == null ? false : true;

        }
    }
}