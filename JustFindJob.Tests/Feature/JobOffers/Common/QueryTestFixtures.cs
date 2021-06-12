using AutoMapper;
using JustFindJob.Application.Contracts.Persistance;
using JustFindJob.Application.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JustFindJob.Tests.Feature.JobOffers.Common
{
    public class QueryTestFixtures
    {
        public IMapper Mapper { get; private set; }

        public QueryTestFixtures()
        {
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfiles>();
            });

            Mapper = configurationProvider.CreateMapper();
        }
    }

    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestFixtures> { }
}
