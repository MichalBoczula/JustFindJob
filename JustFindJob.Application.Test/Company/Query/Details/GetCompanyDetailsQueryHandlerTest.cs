using AutoMapper;
using JustFindJob.Application.Features.Companies.Queries.Details;
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

namespace JustFindJob.Application.Test.Company.Query.Details
{
    [Collection("QueryCollection")]
    public class GetCompanyDetailsQueryHandlerTest
    {
        private readonly JustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetCompanyDetailsQueryHandlerTest(QueryTestBase testBase)
        {
            _context = testBase.Context;
            _mapper = testBase.Mapper;
        }

        [Fact]
        public async Task ShouldReturnCompanyDetails()
        {
            //arrange
            var handler = new GetCompanyDetailsQueryHandler(_context, _mapper);
            //act
            var result = await handler.Handle(new GetCompanyDetailsQuery() { CompanyId = 1}, CancellationToken.None);
            //assert
            result.ShouldBeOfType<CompanyDetailsVm>();
            result.CompanyBasicInfo.Name.ShouldNotBeNullOrEmpty();
            result.CompanyBasicInfo.Size.ShouldNotBeNullOrEmpty();
            result.CompanyBasicInfo.Type.ShouldNotBeNullOrEmpty();
            result.CompanyExtendedInfo.CompanyDescription.ShouldNotBeNullOrEmpty();
        }
    }
}
