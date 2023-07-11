using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KahveOneriSitesi.Data.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-7PB94FK; database=Db_KahveOneriSitesi; integrated security=true");
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Kahve> Kahvelers { get; set; }
        public DbSet<Mesajlar> Mesajlars { get; set; }
        public DbSet<Yorum> Yorumlars { get; set; }

        public DbSet<Oneri> Oneris { get; set; }
    }
}
