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

        public DbSet<Customers> Customers { get; set; }
        public DbSet<ITN_OPRO> ITN_OPRO { get; set; }

        public DbSet<ITN_PRO1> ITN_PRO1 { get; set; }
    }
}
