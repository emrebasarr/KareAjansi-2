using KareAjansi.Entity.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.DAL.Configurations
{
    public class OrganizasyonMankenConfiguration : BaseConfigurations<OrganizasyonManken>
    {
        public override void Configure(EntityTypeBuilder<OrganizasyonManken> builder)
        {
            base.Configure(builder);
            //OrganizasyonManken anahtar ilişkisi
            builder.HasKey(om => new
            {
                om.OrganizasyonId,
                om.MankenId
            });

            builder.HasOne(om => om.Organizasyon)
                .WithMany(o => o.OrganizasyonMankenler)
                .HasForeignKey(o => o.OrganizasyonId);

            builder.HasOne(om => om.Manken)
                .WithMany(m => m.OrganizasyonMankenler)
                .HasForeignKey(om => om.MankenId);
        }
    }
}