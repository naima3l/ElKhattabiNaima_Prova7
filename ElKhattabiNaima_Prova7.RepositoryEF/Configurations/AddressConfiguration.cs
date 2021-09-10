using ElKhattabiNaima_Prova7.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElKhattabiNaima_Prova7.RepositoryEF.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> modelbuilder)
        {
            modelbuilder.ToTable("Address");
            modelbuilder.HasKey(a => a.Id);
            modelbuilder.Property(a => a.City).IsRequired();
            modelbuilder.Property(a => a.Nation).IsRequired();
            modelbuilder.Property(a => a.PostalCode).IsRequired();
            modelbuilder.Property(a => a.Province).IsRequired();
            modelbuilder.Property(a => a.Road).IsRequired();
            modelbuilder.Property(a => a.Type).IsRequired();

            modelbuilder.HasOne(a => a.Contact).WithMany(c => c.Addresses).HasForeignKey(c=> c.ContactId);
        }
    }
}
