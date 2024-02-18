using Intern_Admin_Collaboration.Models;
using Microsoft.EntityFrameworkCore;

namespace Intern_Admin_Collaboration.Data
{
    public class approvedcontext:DbContext
    {
        public approvedcontext(DbContextOptions<approvedcontext> o)  // o means object
           : base(o)
        {

        }

        public DbSet<ApprovedModel> ApprovedInterns  { get; set; }
    }
}
