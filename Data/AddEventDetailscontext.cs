using Intern_Admin_Collaboration.Models;
using Microsoft.EntityFrameworkCore;

namespace Intern_Admin_Collaboration.Data
{
    public class AddEventDetailscontext: DbContext
    {
        public AddEventDetailscontext(DbContextOptions<AddEventDetailscontext> osalary)
        : base(osalary)
        {


        }

        public DbSet<AddEventDetailsModel> AddEventDetails { get; set; }
    }
}
