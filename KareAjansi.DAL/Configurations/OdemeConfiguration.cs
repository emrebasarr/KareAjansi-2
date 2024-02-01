using KareAjansi.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.DAL.Configurations
{
    public class OdemeConfiguration : BaseConfigurations<Odeme>
    {
        public override void Configure(EntityTypeBuilder<Odeme> builder)
        {
            base.Configure(builder);


            builder.HasOne(o => o.Manken)
                .WithMany(m => m.Odemeler)
                .HasForeignKey(o => o.MankenId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.Organizasyon)
                .WithMany(o => o.Odemeler)
                .HasForeignKey(o => o.OrganizasyonId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.Kategori)
             .WithMany(k => k.Odemeler)
             .HasForeignKey(o => o.KategoriId);
        }
    }
}