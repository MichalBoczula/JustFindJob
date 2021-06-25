using AutoMapper;
using JustFindJob.Application.Features.JobOffers.Queries.FilteredList;
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

namespace JustFindJob.Application.Test.JobOffers.Queries.FilteredList
{
    [Collection("QueryCollection")]
    public class GetFilteredJobOfferListHandlerTest
    {
        private readonly JustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetFilteredJobOfferListHandlerTest(QueryTestBase testBase)
        {
            _context = testBase.Context;
            _mapper = testBase.Mapper;
        }

        [Fact]
        public async Task ShouldRetrunAllJobOffers()
        {
            //arrange
            var handler = new GetFilteredJobOfferListHandler(_context, _mapper);
            //act
            var query = new GetFilteredJobOfferListQuery()
            {
                Filters = new ListFilters()
            };
            var result = await handler.Handle(query, CancellationToken.None);
            //assert
            result.Count.ShouldBe(12);
        }

        [Fact]
        public async Task ShouldRetrunAllCSharpJobOffers()
        {
            //arrange
            var handler = new GetFilteredJobOfferListHandler(_context, _mapper);
            //act
            var query = new GetFilteredJobOfferListQuery()
            {
                Filters = new ListFilters()
                {
                    ProggramingLanguages = new List<string>()
                    {
                        "C#"
                    }
                }
            };
            var result = await handler.Handle(query, CancellationToken.None);
            //assert
            result.Count.ShouldBe(3);
        }

        [Fact]
        public async Task ShouldRetrunAllCSharpJobOffersForJuniorPosition()
        {
            //arrange
            var handler = new GetFilteredJobOfferListHandler(_context, _mapper);
            //act
            var query = new GetFilteredJobOfferListQuery()
            {
                Filters = new ListFilters()
                {
                    ProggramingLanguages = new List<string>()
                    {
                        "C#"
                    },
                    ExperienceLevels = new List<string>()
                    {
                        "Junior"
                    }
                }
            };
            var result = await handler.Handle(query, CancellationToken.None);
            //assert
            result.Count.ShouldBe(1);
        }

        [Fact]
        public async Task ShouldRetrunAllJobOffersForJuniorPosition()
        {
            //arrange
            var handler = new GetFilteredJobOfferListHandler(_context, _mapper);
            //act
            var query = new GetFilteredJobOfferListQuery()
            {
                Filters = new ListFilters()
                {
                    ExperienceLevels = new List<string>()
                    {
                        "Junior"
                    }
                }
            };
            var result = await handler.Handle(query, CancellationToken.None);
            //assert
            result.Count.ShouldBe(4);
        }

        [Fact]
        public async Task ShouldRetrunAllCSharpAndJavaJobOffersForJuniorPosition()
        {
            //arrange
            var handler = new GetFilteredJobOfferListHandler(_context, _mapper);
            //act
            var query = new GetFilteredJobOfferListQuery()
            {
                Filters = new ListFilters()
                {
                    ExperienceLevels = new List<string>()
                    {
                        "Junior"
                    },
                    ProggramingLanguages = new List<string>()
                    {
                        "C#",
                        "Java"
                    }
                }
            };
            var result = await handler.Handle(query, CancellationToken.None);
            //assert
            result.Count.ShouldBe(2);
        }

        [Fact]
        public async Task ShouldRetrunAllCSharpAndJavaJobOffersForJuniorAndMidPosition()
        {
            //arrange
            var handler = new GetFilteredJobOfferListHandler(_context, _mapper);
            //act
            var query = new GetFilteredJobOfferListQuery()
            {
                Filters = new ListFilters()
                {
                    ExperienceLevels = new List<string>()
                    {
                        "Junior",
                        "Mid"
                    },
                    ProggramingLanguages = new List<string>()
                    {
                        "C#",
                        "Java"
                    }
                }
            };
            var result = await handler.Handle(query, CancellationToken.None);
            //assert
            result.Count.ShouldBe(4);
        }
    }
}
