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
    public class TechnologyConfiguration : IEntityTypeConfiguration<TechnologyLevel>
    {
        public void Configure(EntityTypeBuilder<TechnologyLevel> builder)
        {
            builder.HasKey(t => t.Id);
        }
    }
}
