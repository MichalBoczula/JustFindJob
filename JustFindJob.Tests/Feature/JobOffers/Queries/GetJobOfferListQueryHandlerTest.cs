using AutoMapper;
using JustFindJob.Application.Contracts.Persistance;
using JustFindJob.Application.Features.JobOffers.Queries.List;
using JustFindJob.Application.Profiles;
using JustFindJob.Domain.Entities;
using JustFindJob.Tests.Feature.JobOffers.Common;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JustFindJob.Tests.Feature.JobOffers.Queries
{
    public class GetJobOfferListQueryHandlerTest
    {
        [Fact]
        public async Task ShouldGetJobOffers()
        {
            //Arrange
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfiles>();
            });
            var mapper = configurationProvider.CreateMapper();

            var list = new List<JobOffer>()
            {
                new JobOffer()
                {
                    Id = 1,
                    CompanyId = 1,
                    ExperienceLevel = ExperienceLevels.Junior,
                    Localization = "Remote"
                },
                new JobOffer()
                {
                    Id = 2,
                    CompanyId = 2,
                    ExperienceLevel = ExperienceLevels.Junior,
                    Localization = "Warsaw"
                }
            };
            var repoMock = new Mock<IJobOfferRepository>();
            repoMock.Setup(x => x.GetList(It.IsAny<CancellationToken>())).ReturnsAsync(list);

            var handler = new GetJobOfferListQueryHandler(repoMock.Object, mapper);
            //Act
            var result = await handler.Handle(new GetJobOfferListQuery(), CancellationToken.None);
            //Assert
            result.ShouldBeOfType<List<JobOfferListVm>>();
            result.Count.ShouldBe(2);
        }
    }
}
