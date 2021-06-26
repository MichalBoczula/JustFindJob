using JustFindJob.Application.Contracts.Identity;
using JustFindJob.Application.Contracts.Persistance;
using JustFindJob.Domain.Common;
using JustFindJob.Domain.Entities;
using JustFindJob.Persistance.Seed;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustFindJob.Persistance
{
    public class JustFindJobDbContext : DbContext , IJustFindJobDbContext
    {
        private readonly ICurrentUserService _currentUserService;

        public JustFindJobDbContext(DbContextOptions<JustFindJobDbContext> options, ICurrentUserService currentUserService) : base(options)
        {
            _currentUserService = currentUserService;
        }

        public DbSet<JobOffer> JobOffers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyDetails> CompanyDetails { get; set; }
        public DbSet<TechStack> TechStacks { get; set; }
        public DbSet<TechnologyLevel> TechnologyLevels { get; set; }
        public DbSet<TechnologyElement> TechnologyElements { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.Email;
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = _currentUserService.Email;
                        entry.Entity.Modified = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = _currentUserService.Email;
                        entry.Entity.Modified = DateTime.Now;
                        entry.Entity.Inactivated = DateTime.Now;
                        entry.Entity.InactivatedBy = _currentUserService.Email;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
