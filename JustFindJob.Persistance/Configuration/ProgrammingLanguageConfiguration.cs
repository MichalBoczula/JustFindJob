using JustFindJob.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Persistance.Configuration
{
    public class ProgrammingLanguageConfiguration : IEntityTypeConfiguration<ProgrammingLanguage>
    {
        public void Configure(EntityTypeBuilder<ProgrammingLanguage> builder)
        {
            builder.HasKey(pl => pl.Id);
            builder.HasMany(pl => pl.JobOffers)
                .WithOne(jo => jo.ProgrammingLanguage)
                .HasForeignKey(jo => jo.ProgrammingLanguageId);
            builder.HasMany(pl => pl.TechnologyElements)
                .WithOne(te => te.ProgrammingLanguage)
                .HasForeignKey(te => te.ProgrammingLanguageId);
        }
    }
}
