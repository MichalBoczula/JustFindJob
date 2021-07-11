using AutoMapper;
using JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList;
using JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList.FindByProgrammingLanguage;
using JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList.FindByTechnologyName;
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

namespace JustFindJob.Application.Test.TechnologyElements.Query.FilteredList.ByTechnologyName
{
    [Collection("QueryCollection")]
    public class GetTechnologyElementFilteredListByNameQueryHandlerTest
    {
        private readonly JustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetTechnologyElementFilteredListByNameQueryHandlerTest(QueryTestBase testBase)
        {
            _context = testBase.Context;
            _mapper = testBase.Mapper;
        }

        [Fact]
        public async Task ShouldReturnAngularAndReactTechnologyElementFilteredList()
        {
            //arrange
            var handler = new GetTechnologyElementFilteredListByNameQueryHandler(_context, _mapper);
            var filters = new ListFiltersTechnologyElement();
            filters.AddTechnologyNames("Angular,React");
            //act
            var result = await handler.Handle(new GetTechnologyElementFilteredListByNameQuery { Filters = filters }, CancellationToken.None);
            //assert
            result.ShouldBeOfType<List<FilteredTechnologyElementVm>>();
            result.Count.ShouldBe(2);
            foreach (var ele in result)
            {
                ele.ProgrammingLanguageDto.Name.ShouldNotBeNullOrEmpty();
                ele.TechnologyElementDto.Name.ShouldNotBeNullOrEmpty();
            }
        }

        [Fact]
        public async Task ShouldReturnAngularTechnologyElementFilteredList()
        {
            //arrange
            var handler = new GetTechnologyElementFilteredListByNameQueryHandler(_context, _mapper);
            var filters = new ListFiltersTechnologyElement();
            filters.AddTechnologyNames("Angular");
            //act
            var result = await handler.Handle(new GetTechnologyElementFilteredListByNameQuery { Filters = filters }, CancellationToken.None);
            //assert
            result.ShouldBeOfType<List<FilteredTechnologyElementVm>>();
            result.Count.ShouldBe(1);
            foreach (var ele in result)
            {
                ele.ProgrammingLanguageDto.Name.ShouldNotBeNullOrEmpty();
                ele.TechnologyElementDto.Name.ShouldNotBeNullOrEmpty();
            }
        }
    }
}
