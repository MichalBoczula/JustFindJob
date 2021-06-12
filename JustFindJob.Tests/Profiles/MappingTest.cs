using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JustFindJob.Tests.Profiles
{
    public class MappingTest : IClassFixture<MappingTestFixture>
    {
        private readonly IConfigurationProvider _configuration;
        private readonly IMapper _mapper;

        public MappingTest(MappingTestFixture fixture)
        {
            _configuration = fixture.Configuration;
            _mapper = fixture.Mapper;
        }

    }
}
