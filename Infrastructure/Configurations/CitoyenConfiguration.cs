using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class CitoyenConfiguration : IEntityTypeConfiguration<Citoyen>
    {
        public void Configure(EntityTypeBuilder<Citoyen> builder)
        {
            builder.OwnsOne(p => p.Adresse, full =>// FULLNAME DETENUE obligatoire  7ata FUllNAME OBLIGATOIRE SINON enty wel ex 
            {
                full.Property(f => f.CodePostal).HasColumnName("CodePostal").IsRequired();
                full.Property(f => f.Rue).HasColumnName("Rue").IsRequired();
                full.Property(f => f.Ville).HasColumnName("Ville").IsRequired();


            }
            );
           
        }
    }
}
