using AutoMapper;
using JustFindJob.Application.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Tests.Profiles
{
    public class MappingTestFixture
    {
        public IConfigurationProvider Configuration { get; set; }
        public IMapper Mapper{ get; set; }

        public MappingTestFixture()
        {
            Configuration = new MapperConfiguration(con =>
            {
                con.AddProfile<MappingProfiles>();
            });
            Mapper = Configuration.CreateMapper();
        }

    }
}
