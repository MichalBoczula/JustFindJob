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
            var handler = new GetJobOfferDetailsQueryHandler(_context, _mapper);

            var result = await handler.Handle(new GetJobOfferDetailsQuery() { JobOfferId = 1}, CancellationToken.None);

            result.ShouldBeOfType<JobOfferDetailsVm>();
        }
    }
}
