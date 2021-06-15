using JustFindJob.Domain.Entities;
using JustFindJob.Persistance;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Test.Common
{
    public static class JustFindJobDbContextFactory
    {
        public static Mock<JustFindJobDbContext> Create()
        {

            var options = new DbContextOptionsBuilder<JustFindJobDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var mock = new Mock<JustFindJobDbContext>(options) { CallBase = true };

            var context = mock.Object;

            context.Database.EnsureCreated();
            ///
            var company1 = new Company()
            {
                Id = 1,
                Name = "TheBestITCompany"
            };
            var job1 = new JobOffer()
            {
                Id = 1,
                Localization = "Warsaw",
                ExperienceLevel = ExperienceLevels.Junior,
                ShortDescription = "desc",
                CompanyId = 1,
            };
            var tech1 = new Technology()
            {
                Id = 1,
                MainTechnologyName = ".Net",
                JobOfferId = 1
            };

            var job2 = new JobOffer()
            {
                Id = 2,
                Localization = "Warsaw",
                ExperienceLevel = ExperienceLevels.Mid,
                ShortDescription = "short desc"
            };

            context.Add(company1);
            context.Add(job1);
            context.Add(tech1);
            context.Add(job2);
            ///
            context.SaveChanges();

            return mock;
        }

        public static void Destroy(JustFindJobDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}
