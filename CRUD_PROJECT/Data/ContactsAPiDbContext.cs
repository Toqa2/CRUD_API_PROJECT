using CRUD_PROJECT.Models;
    using Microsoft.EntityFrameworkCore;

namespace CRUD_PROJECT.Data
{


    public class ContactsAPiDbContext : DbContext

    {
        public ContactsAPiDbContext(DbContextOptions options) : base(options)
        {

        }
        public  DbSet<Contact> Contacts  {get; set;}
    }
}
