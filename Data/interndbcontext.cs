using Intern_Admin_Collaboration.Models;
using Microsoft.EntityFrameworkCore;

namespace Intern_Admin_Collaboration.Data
{
    public class interndbcontext:DbContext
    {
        public interndbcontext(DbContextOptions<interndbcontext> o)  // o means object
            : base(o)
        {

        }

        public DbSet<IALogin> login { get; set; }
    }
}
