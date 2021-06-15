using AutoMapper;
using JustFindJob.Application.Profiles;
using JustFindJob.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JustFindJob.Application.Test.Common
{
    public class QueryTestBase : IDisposable
    {
        public JustFindJobDbContext Context { get; private set; }
        public IMapper Mapper { get; private set; }

        public QueryTestBase()
        {
            Context = JustFindJobDbContextFactory.Create().Object;

            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfiles>();
            });

            Mapper = configurationProvider.CreateMapper();
        }

        public void Dispose()
        {
            JustFindJobDbContextFactory.Destroy(Context);
        }
    }

    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestBase> 
    {
    }
}
