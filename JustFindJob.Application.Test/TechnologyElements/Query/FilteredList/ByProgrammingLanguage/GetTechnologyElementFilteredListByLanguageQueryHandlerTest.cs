using AutoMapper;
using JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList;
using JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList.FindByProgrammingLanguage;
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

namespace JustFindJob.Application.Test.TechnologyElements.Query.FilteredList.ByProgrammingLanguage
{
    [Collection("QueryCollection")]
    public class GetTechnologyElementFilteredListByLanguageQueryHandlerTest
    {
        private readonly JustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetTechnologyElementFilteredListByLanguageQueryHandlerTest(QueryTestBase testBase)
        {
            _context = testBase.Context;
            _mapper = testBase.Mapper;
        }

        [Fact]
        public async Task ShouldReturnCSharpTechnologyElementFilteredList()
        {
            //arrange
            var handler = new GetTechnologyElementFilteredListByLanguageQueryHandler(_context, _mapper);
            var filters = new ListFiltersTechnologyElement();
            filters.ProgrammingLanguages.Add("C#");
            //act
            var result = await handler.Handle(new GetTechnologyElementFilteredListByLanguageQuery { Filters = filters }, CancellationToken.None);
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
        public async Task ShouldReturnCSharpAndJavaTechnologyElementFilteredList()
        {
            //arrange
            var handler = new GetTechnologyElementFilteredListByLanguageQueryHandler(_context, _mapper);
            var filters = new ListFiltersTechnologyElement();
            filters.AddProgrammingLanguages("C#,Java");
            //act
            var result = await handler.Handle(new GetTechnologyElementFilteredListByLanguageQuery { Filters = filters }, CancellationToken.None);
            //assert
            result.ShouldBeOfType<List<FilteredTechnologyElementVm>>();
            result.Count.ShouldBe(4);
            foreach (var ele in result)
            {
                ele.ProgrammingLanguageDto.Name.ShouldNotBeNullOrEmpty();
                ele.TechnologyElementDto.Name.ShouldNotBeNullOrEmpty();
            }
        }
    }
}