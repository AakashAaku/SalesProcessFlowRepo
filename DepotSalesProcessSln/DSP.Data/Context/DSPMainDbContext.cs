using DSP.Domain.DomainEnum;
using DSP.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Data.Context
{
    public class DSPMainDbContext :DbContext
    {
        public DSPMainDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
               modelBuilder.Entity<ITN_PRO1>()
                .HasOne<ITN_OPRO>(s => s.ITN_OPRO)
                .WithMany(g => g.ITN_PRO1)
                .HasForeignKey(s => s.ITN_PROID); 

            //modelBuilder.Entity<AppUsers>()
            //    .HasOne<VendorsCustomer>(v => v.Vendor);
               

            //modelBuilder.Entity<AppUsers>()
            //    .HasOne<VendorsCustomer>(c => c.Customer);

            //modelBuilder.Entity<AppUsers>()
                
               
          


            modelBuilder.Entity<AppUsers>()
                .Property(e => e.Type)
                .HasConversion(t => t.ToString(), t => (UserType)Enum.Parse(typeof(UserType), t));

            modelBuilder.Entity<VendorsCustomer>()
                .Property(vc => vc.Type)
                .HasConversion(cv => cv.ToString(), cv => (UserType)Enum.Parse(typeof(UserType), cv));

                

        }


        public DbSet<Customers> Customers { get; set; }
        public DbSet<ITN_OPRO> ITN_OPRO { get; set; }

        public DbSet<ITN_PRO1> ITN_PRO1 { get; set; }

        public DbSet<VendorsCustomer> VendorCustomer { get; set; }

        public DbSet<AppUsers> AppUser { get; set; }
    }
}
