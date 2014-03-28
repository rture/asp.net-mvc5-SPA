using SPA_Cloud_Sample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SPA_Cloud_Sample.Common
{
    public class ContactRepository : IContactRepository
    {
        private SPA_Cloud_SampleContext db = new SPA_Cloud_SampleContext();

        public async Task<IEnumerable<Contact>> GetAll()
        {
            return await (from b in db.Contacts
                          orderby b.Name
                          select b).Take(10).ToArrayAsync();

        }

        public Task<Contact> GetById(int id)
        {
            return db.Contacts.FindAsync(id);
        }

        public async Task<int> Add(Contact contact)
        {
            db.Contacts.Add(contact);
            return await db.SaveChangesAsync();
        }

        public async Task Remove(int id)
        {
            var contact = await db.Contacts.FindAsync(id);
            db.Contacts.Remove(contact);
            await db.SaveChangesAsync();
        }

        public async Task Update(Contact contact)
        {
            db.Entry(contact).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public void Dispose()
        {
            db.Dispose();
        }


    }
}