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
    public class OrganizasyonMankenData
    {
        public static void SeedOrganizasyonManken(ModelBuilder modelBuilder)
        {
            List<OrganizasyonManken> organizasyonMankenler = new List<OrganizasyonManken>
            {
                new OrganizasyonManken
                {
                  Id = 1,
                  MankenId = 1,
                  OrganizasyonId = 1,
                  KatilmaTarihi = new DateTime(2023, 1, 1),
                  CreatedComputerName = Environment.MachineName,
                  CreatedIpAddress = IpAddressFinder.GetIpAddress()
                }
            };
            modelBuilder.Entity<OrganizasyonManken>().HasData(organizasyonMankenler);
        }
    }
}