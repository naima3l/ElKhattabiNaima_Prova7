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
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> modelbuilder)
        {
            modelbuilder.ToTable("Contact");
            modelbuilder.HasKey(c => c.Id);
            modelbuilder.Property(c => c.Name).IsRequired();
            modelbuilder.Property(c => c.LastName).IsRequired();

            modelbuilder.HasMany(c => c.Addresses).WithOne(a => a.Contact).HasForeignKey(a => a.ContactId);
        }
    }
}
