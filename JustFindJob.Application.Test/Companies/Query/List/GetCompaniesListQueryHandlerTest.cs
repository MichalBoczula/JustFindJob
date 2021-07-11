using AutoMapper;
using JustFindJob.Application.Features.Companies.Queries.List;
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

namespace JustFindJob.Application.Test.Companies.Query.List
{
    [Collection("QueryCollection")]
    public class GetCompaniesListQueryHandlerTest
    {
        private readonly JustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetCompaniesListQueryHandlerTest(QueryTestBase testBase)
        {
            _context = testBase.Context;
            _mapper = testBase.Mapper;
        }

        [Fact]
        public async Task ShouldReturnCompaniesVmList()
        {
            //arrange
            var handler = new GetCompaniesListQueryHandler(_context, _mapper);
            //act
            var result = await handler.Handle(new GetCompaniesListQuery(), CancellationToken.None);
            //assert
            result.ShouldBeOfType<List<CompanyVm>>();
            result.Count.ShouldBe(4);
            foreach (var ele in result)
            {
                ele.Name.ShouldNotBeNullOrEmpty();
                ele.Size.ShouldNotBeNullOrEmpty();
                ele.Type.ShouldNotBeNullOrEmpty();
            }
        }
    }
}
