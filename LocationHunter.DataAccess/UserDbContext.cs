using LocationHunter.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationHunter.DataAccess
{
    public class UserDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); // OnConfiguring metodu DbContextOptionsBuilder nesnesini alır ve veritabanı bağlantısının nasıl yapılandırılacağını belirtir.
            optionsBuilder.UseSqlServer("Server=DESKTOP-N78ME7R;Database=LocationHunter;Integrated Security=true;TrustServerCertificate=true;");
        }
        public DbSet<User> Users { get; set; }
    }
}