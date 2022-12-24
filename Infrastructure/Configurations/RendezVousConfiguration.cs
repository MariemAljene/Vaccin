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
    public class RendezVousConfiguration : IEntityTypeConfiguration<RendezVous>
    {
       
        public void Configure(EntityTypeBuilder<RendezVous> builder)
        {
            builder.HasKey(r => new
            {
                r.CitoyenFK,
                r.VaccinFK,
            }
                );
        }
    }
}
