using DatingApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Server.Configurations.Entities
{
    public class MatchTypeSeedConfiguration : IEntityTypeConfiguration<MatchType>
    {
        public void Configure(EntityTypeBuilder<MatchType> builder)
        {
            builder.HasData(
                new MatchType
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    Unmatch = "Swipe left",
                    Match = "Swipe right",
                    IsMatch = "You have matched with another player."
                },
                new MatchType
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    Unmatch = "Swipe left",
                    Match = "Swipe right",
                    IsMatch = "You have not matched with another player."
                }
                );
        }
    }
}
