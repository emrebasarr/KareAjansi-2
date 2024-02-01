    using KareAjansi.Entity.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace KareAjansi.DAL.Configurations
    {
        public class OrganizasyonConfiguration : BaseConfigurations<Organizasyon>
        {
            public override void Configure(EntityTypeBuilder<Organizasyon> builder)
            {
                base.Configure(builder);
                //Organizasyon ve Odemeler ilişkisi
                builder.HasMany(o => o.Odemeler)
                    .WithOne(odeme => odeme.Organizasyon)
                    .HasForeignKey(odeme => odeme.OrganizasyonId);
            }
        }
    }