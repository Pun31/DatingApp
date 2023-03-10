
using DatingApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Server.Configurations.Entities
{
    public class ConsultationSeedConfiguration : IEntityTypeConfiguration<Consultation>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Consultation> builder)
        {
            builder.HasData(
                new Consultation
                {
                    Id = 1,
                    ConsultName = "John",
                    ConsultDate = DateTime.Now,
                    ConsultReport = "This person is more suited to your preferences.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Consultation
                {
                    Id = 2,
                    ConsultName = "Lim",
                    ConsultDate = DateTime.Now,
                    ConsultReport = "This person is not suited to your preferences.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                }
                );
        }
    }
}
