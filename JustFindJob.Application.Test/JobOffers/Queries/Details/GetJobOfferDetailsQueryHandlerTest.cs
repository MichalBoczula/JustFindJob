using AutoMapper;
using JustFindJob.Application.Features.JobOffers.Queries.Details;
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

namespace JustFindJob.Application.Test.JobOffers.Queries.Details
{
    [Collection("QueryCollection")]
    public class GetJobOfferDetailsQueryHandlerTest
    {

        private readonly JustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetJobOfferDetailsQueryHandlerTest(QueryTestBase testBase)
        {
            _context = testBase.Context;
            _mapper = testBase.Mapper;
        }

        [Fact]
        public async Task ShouldReturnDetails()
        {
            //arrange
            var handler = new GetJobOfferDetailsQueryHandler(_context, _mapper);
            //act
            var result = await handler.Handle(new GetJobOfferDetailsQuery() { JobOfferId = 1}, CancellationToken.None);
            //assert
            result.ShouldBeOfType<JobOfferDetailsVm>();
            result.JobOfferDto.Localization.ShouldBe("Wroclaw");
            result.JobOfferDto.ExperienceLevel.ShouldBe("Junior");
            result.JobOfferDto.ShortDescription.ShouldNotBeNullOrEmpty();
            result.JobOfferDto.LongDescription.ShouldNotBeNullOrEmpty();
            result.CompanyDto.Name.ShouldBe("The Best IT");
            result.CompanyDto.Size.ShouldBe("50 - 100 employees");
            result.CompanyDto.Type.ShouldBe("Software House");
            result.CompanyDto.Id.ShouldBe(1);
            result.ProgrammingLanguageDto.Name.ShouldBe("C#");
            result.TechStackDtos.Count.ShouldBe(3);
            result.TechStackDtos.ToList()[0].TechnologyLevelDto.Level.ShouldBe("Begginer");
            result.TechStackDtos.ToList()[0].TechnologyElementDto.Name.ShouldBe(".Net");
        }
    }
}
