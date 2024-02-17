using Intern_Admin_Collaboration.Models;
using Microsoft.EntityFrameworkCore;

namespace Intern_Admin_Collaboration.Data
{
    public class Addcontext:DbContext
    {
        public Addcontext(DbContextOptions<Addcontext>ob)
        :base(ob)
        {
        
        
        }

        public DbSet<Interns> AddIntern { get; set; }


    }
}
