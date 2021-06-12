using AutoMapper;
using JustFindJob.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JustFindJob.Tests.Feature.JobOffer.Common
{
    public class QueryTestFixtures : IDisposable
    {
        public IJobOfferDbContext Context { get; private set; }
        public IMapper Mapper { get; private set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestFixtures> { }
}
