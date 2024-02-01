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
    public class OrganizasyonData
    {
        public static void SeedOrganizasyon(ModelBuilder modelBuilder)
        {
            List<Organizasyon> organizasyonlar = new List<Organizasyon>()
            {
               new Organizasyon
               {
                   Id = 1,
                   Ad = "Ornek Organizasyon",
                   BaslangicTarihi = new DateTime(2023, 1, 1),
                   BitisTarihi = new DateTime(2023, 1, 7),
                   Sehir = "İstanbul",
                   Firma = "Ornek Firma",
                   GunSayisi = 7,
                   Odenecek = 10000,
                   CreatedComputerName = Environment.MachineName,
                   CreatedIpAddress = IpAddressFinder.GetIpAddress()
               }
            };
            modelBuilder.Entity<Organizasyon>().HasData(organizasyonlar);
        }
    }
}