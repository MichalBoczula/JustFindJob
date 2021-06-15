using JustFindJob.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustFindJob.Application.Contracts.Persistance
{
    public interface IJustFindJobDbContext
    {
        DbSet<JobOffer> JobOffers { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<CompanyDetails> CompanyDetails { get; set; }
        DbSet<TechStack> TechStacks { get; set; }
        DbSet<TechnologyLevel> TechnologyLevels { get; set; }
        DbSet<TechnologyElement> TechnologyElements { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
