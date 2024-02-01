using KareAjansi.Entity.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.DAL.Configurations
{
    public class KategoriConfiguration : BaseConfigurations<Kategori>
    {
        public override void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);
            //Kategori ile Mankenler ilişkisi
            builder.HasMany(k => k.Mankenler)
                .WithOne(m => m.Kategori)
                .HasForeignKey(m => m.KategoriId);

            builder.HasMany(k => k.Odemeler)
             .WithOne(o => o.Kategori)
             .HasForeignKey(o => o.KategoriId);
        }
    }
}