using Intern_Admin_Collaboration.Models;
using Microsoft.EntityFrameworkCore;


namespace Intern_Admin_Collaboration.Data
{
    public class Taskcontext:DbContext
    {
        public Taskcontext(DbContextOptions<Taskcontext> otask)  
           : base(otask)
        {

        }

        public DbSet<TaskdetailModel> Taskinterns { get; set; }
    }
}
