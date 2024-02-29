using Intern_Admin_Collaboration.Models;
using Microsoft.EntityFrameworkCore;

namespace Intern_Admin_Collaboration.Data
{
    public class Certificatecontext:DbContext
    {
        public Certificatecontext(DbContextOptions<Certificatecontext> ocerti)
           : base(ocerti)
        {

        }

        public DbSet<CertificateModel> Certificatedetails { get; set; }


    }
}
