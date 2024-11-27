using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_12_1
{
    internal class BookDbContext : DbContext
    {
        public DbSet<Book>? Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = TNN-HIU-LEGION-; " +
                                        "Database = TestEF; " +
                                        "Trusted_Connection = true; " +
                                        "TrustServerCertificate=True");
        }
    }
}
