using DotNetAngularCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DotNetAngularCRUD.Data
{
    public class DBContextClass : DbContext
    {
        public DBContextClass(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
