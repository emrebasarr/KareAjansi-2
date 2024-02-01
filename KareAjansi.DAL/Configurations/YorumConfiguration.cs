using KareAjansi.Entity.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.DAL.Configurations
{
    public class YorumConfiguration : BaseConfigurations<Yorum>
    {
        public override void Configure(EntityTypeBuilder<Yorum> builder)
        {
            base.Configure(builder);

            builder.HasOne(y => y.Manken)
                .WithMany(m => m.yorumlar)
                .HasForeignKey(y => y.MankenId);
        }
    }
}