using AutoMapper;
using JustFindJob.Application.Contracts.Persistance;
using JustFindJob.Application.Features.JobOffers.Queries.List;
using JustFindJob.Tests.Feature.JobOffer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JustFindJob.Tests.Feature.JobOffer.Queries
{
    public class GetJobOfferListQueryHandlerTest
    {
        private readonly IJobOfferDbContext _context;
        private readonly IMapper _mapper;

        public GetJobOfferListQueryHandlerTest(QueryTestFixtures fixtures)
        {
            _context = fixtures.Context;
            _mapper = fixtures.Mapper;
        }

        [Fact]
        public async Task ShouldGetJobOffers()
        {
            var handler = new GetJobOfferListQueryHandler(_context, _mapper);
            var result = await handler.Handle(new GetJobOfferListQuery(), CancellationToken.None);
            ///act
        }
    }
}
