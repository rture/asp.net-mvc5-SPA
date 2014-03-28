using SPA_Cloud_Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace SPA_Cloud_Sample.Common
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> GetAll();
        Task<Contact> GetById(int id);
        Task<int> Add(Contact contact);

        Task Remove(int id);

        Task Update(Contact contact);

        void Dispose();
    }

   
}
