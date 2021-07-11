using AutoMapper;
using JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList;
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

namespace JustFindJob.Application.Test.TechnologyElements.Query.FilteredList
{
    [Collection("QueryCollection")]
    public class GetTechnologyElementFilteredListQueryHandlerTest
    {
        private readonly JustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetTechnologyElementFilteredListQueryHandlerTest(QueryTestBase testBase)
        {
            _context = testBase.Context;
            _mapper = testBase.Mapper;
        }

        [Fact]
        public async Task ShouldReturnCSharpTechnologyElementFilteredList()
        {
            //arrange
            var handler = new GetTechnologyElementFilteredListQueryHandler(_context, _mapper);
            var filters = new ListFiltersTechnologyElement();
            filters.ProgrammingLanguages.Add("C#");
            //act
            var result = await handler.Handle(new GetTechnologyElementFilteredListQuery { Filters = filters }, CancellationToken.None);
            //assert
            result.ShouldBeOfType<List<FilteredTechnologyElementVm>>();
            result.Count.ShouldBe(2);
            foreach(var ele in result)
            {
                ele.ProgrammingLanguageDto.Name.ShouldNotBeNullOrEmpty();
                ele.TechnologyElementDto.Name.ShouldNotBeNullOrEmpty();
            }
        }
    }
}
