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
    public class YorumData
    {
        public static void SeedYorum(ModelBuilder modelBuilder)
        {
            List<Yorum> yorum = new List<Yorum>()
            {
                new Yorum
                {
                    Id=1,
                    Yazari = "Emre",
                    Yorumu = "Böyle devam et",
                    MankenId=1,
                    CreatedComputerName = Environment.MachineName,
                    CreatedIpAddress = IpAddressFinder.GetIpAddress()
                }
            };
            modelBuilder.Entity<Yorum>().HasData(yorum);
        }
    }
}