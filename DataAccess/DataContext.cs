
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-QFIKDEC; Database=RegisterDB; Trusted_Connection=True;");
            
        }

        public DbSet<Users>? Users { get; set; }
    }
}
