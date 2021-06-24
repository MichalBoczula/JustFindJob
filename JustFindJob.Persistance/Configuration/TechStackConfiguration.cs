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
    public class TechStackConfiguration : IEntityTypeConfiguration<TechStack>
    {
        public void Configure(EntityTypeBuilder<TechStack> builder)
        {
            builder.HasKey(ts => ts.Id);
        }
    }
}
