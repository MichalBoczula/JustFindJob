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
