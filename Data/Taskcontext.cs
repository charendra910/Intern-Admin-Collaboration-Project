using Intern_Admin_Collaboration.Models;
using Microsoft.EntityFrameworkCore;


namespace Intern_Admin_Collaboration.Data
{
    public class Taskcontext:DbContext
    {
        public Taskcontext(DbContextOptions<Taskcontext> objtask)  
           : base(objtask)
        {

        }

        public DbSet<TaskdetailModel> TaskInterns { get; set; }
    }
}
