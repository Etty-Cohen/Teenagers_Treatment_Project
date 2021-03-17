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
        public TreatmentContext()
           : base("data source =.\\SQLEXPRESS; initial catalog = project; integrated security = SSPI")
        { }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Mentor> Mentors { get; set; }
        public virtual DbSet<Volunteer> Volunteers { get; set; }
        public virtual DbSet<Treatment‏> Treatment‏s { get; set; }
        public virtual DbSet<Teenager‏> Teenager‏s { get; set; }


       


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Mentor>()
                .HasMany(m => m.Teenagers‏)
                .WithMany(t => t.Volunteers);

            modelBuilder.Entity<Mentor>()
                .HasMany(v => v.Treatments)
                .WithOptional(t => t.Volunteer)
                .HasForeignKey(t => t.VolunteerId);*/

            modelBuilder.Entity<Volunteer>()
                .HasMany(v => v.Teenagers‏)
                .WithMany(t => t.Volunteers);

            modelBuilder.Entity<Volunteer>()
                .HasMany(v => v.Treatments)
                .WithOptional(t => t.Volunteer)
                .HasForeignKey(t => t.VolunteerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teenager>()
                .HasMany(t => t.Treatments)
                .WithRequired(t => t.Teenager)
                .HasForeignKey(t => t.TeenagerId)
                .WillCascadeOnDelete(false);


            
            //    modelBuilder.Entity<Package>().Property(p => p.RecipientId).IsOptional();
            //    modelBuilder.Entity<Distribution>().Property(p => p.AdminId).IsOptional();
            //    modelBuilder.Entity<Distribution>().Property(p => p.VolunteerId).IsOptional();

            //}

        }
    }
}
