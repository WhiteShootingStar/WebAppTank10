using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STD.Models
{
    public partial class StdDbContext : DbContext
    {
        public StdDbContext(DbContextOptions<StdDbContext> options)
               : base(options)
        {
        }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s16550;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Std> Stds { get; set; }
    }
}
