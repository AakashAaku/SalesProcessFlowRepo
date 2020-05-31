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

            modelBuilder.Entity<ITN_PDN1>()
           .HasOne<ITN_OPDN>(s => s.ITN_OPDN)
           .WithMany(g => g.ITN_PDN1)
           .HasForeignKey(s => s.ITN_OPDNID);

            modelBuilder.Entity<ITN_RPD1>()
         .HasOne<ITN_ORPD>(s => s.ITN_ORPD)
         .WithMany(g => g.ITN_RPD1)
         .HasForeignKey(s => s.ITN_ORPDID);

            modelBuilder.Entity<ITN_INV1>()
         .HasOne<ITN_OINV>(s => s.ITN_OINV)
         .WithMany(g => g.ITN_INV1)
         .HasForeignKey(s => s.ITN_OINVID);

            modelBuilder.Entity<ITN_PRO1>()
               .HasOne<ITN_OPRO>(s => s.ITN_OPRO)
               .WithMany(g => g.ITN_PRO1)
               .HasForeignKey(s => s.ITN_PROID);




            modelBuilder.Entity<DspUsers>()
                .Property(e => e.Type)
                .HasConversion(t => t.ToString(), t => (UserType)Enum.Parse(typeof(UserType), t));

            modelBuilder.Entity<VendorsCustomer>()
                .Property(vc => vc.Type)
                .HasConversion(cv => cv.ToString(), cv => (UserType)Enum.Parse(typeof(UserType), cv));



            modelBuilder.Entity<ITN_RDN1>()
              .HasOne<ITN_ORDN>(s => s.ITN_ORDN)
              .WithMany(g => g.ITN_RDN1)
              .HasForeignKey(s => s.ITN_ORDNID);
        }

 


        public DbSet<VendorCustomers> Customers { get; set; }
        public DbSet<ITN_OPRO> ITN_OPRO { get; set; }

        public DbSet<ITN_PRO1> ITN_PRO1 { get; set; }

        public DbSet<VendorsCustomer> VendorCustomer { get; set; }


        public DbSet<ITN_OPDN> ITN_OPDN { get; set; }

        public DbSet<ITN_PDN1> ITN_PDN1 { get; set; }

        public DbSet<ITN_ORPD> ITN_ORPD { get; set; }

        public DbSet<ITN_RPD1> ITN_RPD1 { get; set; }

        public DbSet<ITN_OINV> ITN_OINV { get; set; }

        public DbSet<ITN_INV1> ITN_INV1 { get; set; }

        public DbSet<DspUsers> DspUsers { get; set; } 

        public DbSet<Licenses> Licenses { get; set; }

        public DbSet<ITN_ORDN> ITN_ORDN { get; set; }

        public DbSet<ITN_RDN1> ITN_RDN1 { get; set; }

    }
}
