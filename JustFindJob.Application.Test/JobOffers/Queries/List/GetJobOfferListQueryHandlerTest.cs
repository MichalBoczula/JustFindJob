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
            var handler = new GetJobOfferListQueryHandler(_context, _mapper);

            var result = await handler.Handle(new GetJobOfferListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<JobOfferListVm>>();
            result.Count.ShouldBe(2);
        }
    }
}
