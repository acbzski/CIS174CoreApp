using CIS174CoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CIS174CoreApp
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Server=tcp:cis174acbaszczynski.database.windows.net,1433;Initial Catalog=CIS174;Persist Security Info=False;User ID=acbaszczynski;Password=Fuckazure!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}
