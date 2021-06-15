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
    class TechnologyElementConfiguration : IEntityTypeConfiguration<TechnologyElement>
    {
        public void Configure(EntityTypeBuilder<TechnologyElement> builder)
        {
            builder.HasKey(te => te.Id);
        }
    }
}
