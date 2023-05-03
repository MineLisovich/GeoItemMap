using GeoItemMap.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DataBase
{
    public class AppDbContext : DbContext
    {
        public DbSet<GeoItem> GeoItems { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<GeoItem>().HasData(new GeoItem
            {
               Id = 1,
               X = 34.44,
               Y = 56.43,
               Description = "Какой-то текст"
            });
        }
    }
}
