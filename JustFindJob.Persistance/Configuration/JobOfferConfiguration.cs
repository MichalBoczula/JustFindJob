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
    public class JobOfferConfiguration : IEntityTypeConfiguration<JobOffer>
    {
        public void Configure(EntityTypeBuilder<JobOffer> builder)
        {
            builder.HasKey(jo => jo.Id);
            builder.HasOne(jo => jo.Company)
                .WithMany(c => c.JobOffers)
                .HasForeignKey(jo => jo.CompanyId);
            builder.HasOne(jo => jo.Technology)
                .WithOne(t => t.JobOffer)
                .HasForeignKey<Technology>(t => t.JobOfferId);
        }
    }
}
