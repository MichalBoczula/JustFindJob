using AutoMapper;
using JustFindJob.Application.Features.JobOffers.Queries.List;
using JustFindJob.Application.Test.Common;
using JustFindJob.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Shouldly;
using JustFindJob.Domain.Entities;

namespace JustFindJob.Application.Test.JobOffers.Queries.List
{
    [Collection("QueryCollection")]
    public class GetJobOfferListQueryHandlerTest
    {
        private readonly JustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetJobOfferListQueryHandlerTest(QueryTestBase testBase)
        {
            _context = testBase.Context;
            _mapper = testBase.Mapper;
        }

        [Fact]
        public async Task ShouldReturnList()
        {
            //arrange
            var handler = new GetJobOfferListQueryHandler(_context, _mapper);
            //act
            var result = await handler.Handle(new GetJobOfferListQuery(), CancellationToken.None);
            //assert
            result.ShouldBeOfType<List<JobOfferListVm>>();
            result.Count.ShouldBe(12);
            foreach (var ele in result)
            {
                ele.ProgrammingLanguageDto.Name.ShouldNotBeNullOrEmpty();
                ele.CompanyDto.Name.ShouldNotBeNullOrEmpty();
                ele.JobOfferDto.Localization.ShouldNotBeNullOrEmpty();
                ele.JobOfferDto.ExperienceLevel.ShouldBeOfType<ExperienceLevels>();
                ele.JobOfferDto.ShortDescription.ShouldNotBeNullOrEmpty();
            }
        }
    }
}
