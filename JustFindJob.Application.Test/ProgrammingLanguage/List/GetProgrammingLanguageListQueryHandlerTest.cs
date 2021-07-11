using AutoMapper;
using JustFindJob.Application.Features.ProgrammingLanguages.Queries;
using JustFindJob.Application.Features.ProgrammingLanguages.Queries.List;
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

namespace JustFindJob.Application.Test.ProgrammingLanguage.List
{
    [Collection("QueryCollection")]
    public class GetProgrammingLanguageListQueryHandlerTest
    {
        private readonly JustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetProgrammingLanguageListQueryHandlerTest(QueryTestBase testBase)
        {
            _context = testBase.Context;
            _mapper = testBase.Mapper;
        }

        [Fact]
        public async Task ShouldReturnProgrammingLanguageList()
        {
            //arrange
            var handler = new GetProgrammingLanguageListQueryHandler(_context, _mapper);
            //act
            var result = await handler.Handle(new GetProgrammingLanguageListQuery(), CancellationToken.None);
            //assert
            result.ShouldBeOfType<List<ProgrammingLanguagesVm>>();
            result.Count.ShouldBe(6);
            foreach(var ele  in result)
            {
                ele.Name.ShouldNotBeNullOrEmpty();
            }
        }
    }
}
