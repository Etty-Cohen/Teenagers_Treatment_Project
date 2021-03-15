using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    class TreatmentContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Treatment‏> Treatment‏s { get; set; }
        public DbSet<Teenager‏> Teenager‏s { get; set; }


        public TreatmentContext()
            : base("data source =.\\SQLEXPRESS; initial catalog = project; integrated security = SSPI")
        {


        }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
           // modelBuilder.Entity<Volunteer>()
           //.HasOptional(v => v.Teenager)
           //.WithMany(t => t.Volunteer)
          // .WillCascadeOnDelete(false);
           // modelBuilder.Entity<Distribution>()
        //  .HasOptional<User>(s => s.Volunteer)
        //  .WithMany()
        //  .WillCascadeOnDelete(false);
        //    modelBuilder.Entity<Distribution>()
        //  .HasOptional<User>(s => s.Admin)
        //  .WithMany()
        //  .WillCascadeOnDelete(false);
        //    modelBuilder.Entity<Package>().Property(p => p.RecipientId).IsOptional();
        //    modelBuilder.Entity<Distribution>().Property(p => p.AdminId).IsOptional();
        //    modelBuilder.Entity<Distribution>().Property(p => p.VolunteerId).IsOptional();

            //}

        //ז}
    }
}
