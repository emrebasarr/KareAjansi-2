using KareAjansi.Common.IpFinder;
using KareAjansi.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.DAL.DataSeeding
{
    public class KategoriData
    {
        public static void SeedKategori(ModelBuilder modelBuilder)
        {
            //Kategoriler
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori
                {
                    Id = 1,
                    Ad = "Kategori1",
                    CreatedComputerName = Environment.MachineName,
                    CreatedIpAddress = IpAddressFinder.GetIpAddress()
                },
                new Kategori
                {
                    Id= 2,
                    Ad = "Kategori2",
                    CreatedComputerName = Environment.MachineName,
                    CreatedIpAddress = IpAddressFinder.GetIpAddress()
                },
                new Kategori
                {
                    Id = 3,
                    Ad = "Kategori3",
                    CreatedComputerName = Environment.MachineName,
                    CreatedIpAddress = IpAddressFinder.GetIpAddress()
                }
            };
            modelBuilder.Entity<Kategori>().HasData(kategoriler);
        }
    }
}