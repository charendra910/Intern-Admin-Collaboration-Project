using Intern_Admin_Collaboration.Models;
using Microsoft.EntityFrameworkCore;

namespace Intern_Admin_Collaboration.Data
{
    public class Dashcontext:DbContext
    {
        public Dashcontext(DbContextOptions<Dashcontext>obj)
        :base(obj)
        
        {
            
        }

        public DbSet<DashboardModel> DashboardIntern { get; set; }
    }
}

