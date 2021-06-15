using JustFindJob.API.Controllers.Common;
using JustFindJob.Application.Features.JobOffers.Queries.Details;
using JustFindJob.Application.Features.JobOffers.Queries.List;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustFindJob.API.Controllers.JobOffers
{
    [Route("api/jobs")]
    public class JobOfferController : BaseController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<JobOfferDetailsVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetJobOfferDetailsQuery() { JobOfferId = id });
            return Ok(vm);
        }

        [HttpGet]
        public async Task<ActionResult<JobOfferListVm>> GetList()
        {
            var vm = await Mediator.Send(new GetJobOfferListQuery());
            return Ok(vm);
        }
    }
}
