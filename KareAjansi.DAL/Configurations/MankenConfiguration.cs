using KareAjansi.Entity.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.DAL.Configurations
{
    public class MankenConfiguration : BaseConfigurations<Manken>
    {
        public override void Configure(EntityTypeBuilder<Manken> builder)
        {
            base.Configure(builder);

            builder.HasOne(m => m.Kategori)
                .WithMany(k => k.Mankenler)
                .HasForeignKey(m => m.KategoriId);

            builder.HasMany(m => m.yorumlar)
                .WithOne(y => y.Manken)
                .HasForeignKey(y => y.MankenId);
        }
    }
}