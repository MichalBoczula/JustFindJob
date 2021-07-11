using AutoMapper;
using JustFindJob.Application.Features.ProgrammingLanguages.Queries;
using JustFindJob.Application.Features.ProgrammingLanguages.Queries.FindByName;
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

namespace JustFindJob.Application.Test.ProgrammingLanguage.FindByName
{
    [Collection("QueryCollection")]
    public class GetProgrammingLanguageByNameQueryHandlerTest

    {
        private readonly JustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetProgrammingLanguageByNameQueryHandlerTest(QueryTestBase testBase)
        {
            _context = testBase.Context;
            _mapper = testBase.Mapper;
        }

        [Fact]
        public async Task ShouldReturnProgrammingLanguage()
        {
            //arrange
            var handler = new GetProgrammingLanguageByNameQueryHandler(_context, _mapper);
            //act
            var result = await handler.Handle
                (new GetProgrammingLanguageByNameQuery() 
                    { 
                        ProgrammingLangaugeName = "C#"
                    }, 
                    CancellationToken.None);
            //assert
            result.ShouldBeOfType<ProgrammingLanguagesVm>();
            result.Name.ShouldNotBeNullOrEmpty();
        }
    }
}
