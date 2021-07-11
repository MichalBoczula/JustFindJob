using AutoMapper;
using JustFindJob.Application.Features.TechnologyElements.Queries;
using JustFindJob.Application.Features.TechnologyElements.Queries.List;
using JustFindJob.Application.Test.Common;
using JustFindJob.Persistance;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JustFindJob.Application.Test.TechnologyElements.Query.List
{
    [Collection("QueryCollection")]
    public class GetTechnologyElementListQueryHandlerTest
    {
        private readonly JustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetTechnologyElementListQueryHandlerTest(QueryTestBase testBase)
        {
            _context = testBase.Context;
            _mapper = testBase.Mapper;
        }

        [Fact]
        public async Task ShouldReturnTechnologyElementList()
        {
            //arrange
            var handler = new GetTechnologyElementListQueryHandler(_context, _mapper);
            //act
            var result = await handler.Handle(new GetTechnologyElementListQuery(), CancellationToken.None);
            //assert
            result.ShouldBeOfType<List<TechnologyElementVm>>();
            result.Count.ShouldBe(15);
        }
    }
}
