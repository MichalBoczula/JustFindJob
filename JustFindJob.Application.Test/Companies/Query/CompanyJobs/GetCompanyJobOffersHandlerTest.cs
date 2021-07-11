using AutoMapper;
using JustFindJob.Application.Features.Companies.Queries.CompanyJobs;
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

namespace JustFindJob.Application.Test.Companies.Query.CompanyJobs
{
    [Collection("QueryCollection")]
    public class GetCompanyJobOffersHandlerTest
    {
        private readonly JustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetCompanyJobOffersHandlerTest(QueryTestBase testBase)
        {
            _context = testBase.Context;
            _mapper = testBase.Mapper;
        }

        [Fact]
        public async Task ShouldReturnCompanyJobOffersList()
        {
            //arrange
            var handler = new GetCompanyJobOffersQueryHandler(_context, _mapper);
            //act
            var result = await handler.Handle(new GetCompanyJobOffersQuery { CompanyId = 1 }, CancellationToken.None);
            //assert
            result.ShouldBeOfType<List<CompanyJobOfferVm>>();
            result.Count.ShouldBe(4);
            foreach (var ele in result)
            {
                ele.ProgrammingLanguageDto.Name.ShouldNotBeNullOrEmpty();
                ele.CompanyDto.Name.ShouldNotBeNullOrEmpty();
                ele.JobOfferDto.Localization.ShouldNotBeNullOrEmpty();
                ele.JobOfferDto.ExperienceLevel.ShouldBeOfType<string>();
                ele.JobOfferDto.ShortDescription.ShouldNotBeNullOrEmpty();
            }
        }
    }
}
