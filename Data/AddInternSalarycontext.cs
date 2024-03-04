using Intern_Admin_Collaboration.Models;
using Microsoft.EntityFrameworkCore;

namespace Intern_Admin_Collaboration.Data
{
    public class AddInternSalarycontext: DbContext
    {
        public AddInternSalarycontext(DbContextOptions<AddInternSalarycontext> osalary)
        : base(osalary)
        {


        }

        public DbSet<AddInternSalaryModel> AddInternSalary { get; set; }
    }
}
