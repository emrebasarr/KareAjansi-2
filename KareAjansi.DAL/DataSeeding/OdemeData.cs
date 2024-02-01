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
    public class OdemeData
    {
        public static void SeedOdeme(ModelBuilder modelBuilder)
        {
            List<Odeme> odemeler = new List<Odeme>()
            {
                new Odeme
                {
                    Id = 1,
                    MankenAdi = "Emre",
                    Konum = true,
                    KonaklamaUcreti = 40,
                    YemekUcreti = 50, 
                    Odenecek = 0, 
                    Harcama = 0, 
                    Toplam = 0, 
                    Kar = 0,
                    MankenId = 1, 
                    OrganizasyonId = 1, 
                    KategoriId = 1,
                    CreatedComputerName = Environment.MachineName,
                    CreatedIpAddress = IpAddressFinder.GetIpAddress()
                }

            };
            modelBuilder.Entity<Odeme>().HasData(odemeler);
        }     
    }
}