using Microsoft.EntityFrameworkCore;
using System.Data;
using WebApi.Model;

namespace WebApi.Database
{
    public class databasedbcontext : DbContext
    {
        public databasedbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<employe> employee { get; set; }

        

    }
}
