using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Buildar.Model;
using Microsoft.Data.SqlClient;
using Buildar.Model.Parts;

namespace Buildar.DataAccess
{
    public class BuildarContext : DbContext
    {
        public BuildarContext(DbContextOptions<BuildarContext> options) 
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Cooler> Coolers { get; set; }
        public DbSet<Cpu> Cpus { get; set; }
        public DbSet<Gpu> Gpus { get; set; }
        public DbSet<Memory> Memorys { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<Psu> Psus { get; set; }
        public DbSet<Build> Builds { get; set; }
        public DbSet<Storage> Storages { get; set; }

        public BuildarContext() { 
        }
        
    }
}
