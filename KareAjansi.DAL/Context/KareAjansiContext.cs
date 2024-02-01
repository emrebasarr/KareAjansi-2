using KareAjansi.Common.IpFinder;
using KareAjansi.DAL.Configurations;
using KareAjansi.DAL.DataSeeding;
using KareAjansi.Entity.Base;
using KareAjansi.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.DAL.Context
{
    public class KareAjansiContext : DbContext
    {
        public KareAjansiContext(DbContextOptions<KareAjansiContext> options) : base(options)
        {

        }

        //veritabanı tanımlama metodu
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-R1GI7QV\\SQLEXPRESS;Database=KareAjansiDb;Trusted_Connection=True;TrustServerCertificate=True");
            }
            base.OnConfiguring(optionsBuilder);
        }

        //Custom validation (veritabanı oluşturulurken)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MankenConfiguration());
            modelBuilder.ApplyConfiguration(new KategoriConfiguration());
            modelBuilder.ApplyConfiguration(new OrganizasyonConfiguration());
            modelBuilder.ApplyConfiguration(new YorumConfiguration());
            modelBuilder.ApplyConfiguration(new OdemeConfiguration());
            modelBuilder.ApplyConfiguration(new OrganizasyonMankenConfiguration());

            //Seeding
            KategoriData.SeedKategori(modelBuilder);
            MankenData.SeedManken(modelBuilder);
            OrganizasyonData.SeedOrganizasyon(modelBuilder);
            OrganizasyonMankenData.SeedOrganizasyonManken(modelBuilder);
            YorumData.SeedYorum(modelBuilder);
            OdemeData.SeedOdeme(modelBuilder);
        }

        //Dbset
        public DbSet<Manken> Mankenler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Organizasyon> Organizasyonlar { get; set; }
        public DbSet<OrganizasyonManken> OrganizasyonMankenler { get; set; }
        public DbSet<Odeme> Odemeler { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }

        public override int SaveChanges()
        {
            var modifierEntries = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified || x.State == EntityState.Added);

            try
            {
                foreach (var item in modifierEntries)
                {
                    var entityRepository = item.Entity as BaseClass;

                    if (item.State == EntityState.Added)
                    {
                        //Veri Yeni Eklenirken
                        entityRepository.CreatedDate = DateTime.Now;
                        entityRepository.CreatedComputerName = Environment.MachineName;
                        entityRepository.CreatedIpAddress = IpAddressFinder.GetIpAddress();
                    }
                    else if (item.State == EntityState.Modified)
                    {
                        //Veri Güncellenirken
                        entityRepository.UpdatedDate = DateTime.Now;
                        entityRepository.UpdatedComputerName = Environment.MachineName;
                        entityRepository.UpdatedIpAddress = IpAddressFinder.GetIpAddress();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return base.SaveChanges();
        }
    }
}