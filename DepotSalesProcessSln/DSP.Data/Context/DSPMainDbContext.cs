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
        }



        public DbSet<Customers> Customers { get; set; }
        public DbSet<ITN_OPRO> ITN_OPRO { get; set; }

        public DbSet<ITN_PRO1> ITN_PRO1 { get; set; }


        public DbSet<ITN_OPDN> ITN_OPDN { get; set; }

        public DbSet<ITN_PDN1> ITN_PDN1 { get; set; }
    }
}
