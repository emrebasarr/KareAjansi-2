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
    public class MankenData
    {
        public static void SeedManken(ModelBuilder modelBuilder)
        {
            //Mankenler
            List<Manken> mankenler = new List<Manken>()
            {
                new Manken
                {
                    Id = 1,
                    Ad = "Emre",
                    Soyad = "Bilge",
                    Adres = "Ornek Adres",
                    Tel1  = "555-555-5555",
                    Tel2  = "555-555-5556",
                    AyakkabiNo = "42",
                    Beden = "Medium",
                    Kilo = "65",
                    SacRengi = "Siyah",
                    GozRengi = "Kahverengi",
                    SehirDisiCalisabilmeDurumu = true,
                    Ehliyet = true,
                    YabanciDil = "İngilizce",
                    Ozellik = "Ornek Ozellik",
                    Cinsiyet = "Bay",
                    KategoriId = 1,
                    CreatedComputerName = Environment.MachineName,
                    CreatedIpAddress = IpAddressFinder.GetIpAddress()
                }
            };
            modelBuilder.Entity<Manken>().HasData(mankenler);
        }
    }
}