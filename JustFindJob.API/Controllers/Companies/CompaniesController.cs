using JustFindJob.API.Controllers.Common;
using JustFindJob.Application.Features.Companies.Queries.CompanyJobs;
using JustFindJob.Application.Features.Companies.Queries.Details;
using JustFindJob.Application.Features.Companies.Queries.List;
using JustFindJob.Application.Features.JobOffers.Queries.List;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustFindJob.API.Controllers.Companies
{
    [Route("api/companies")]
    [ApiController]
    [AllowAnonymous]
    public class CompaniesController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<CompanyVm>> GetList()
        {
            var vm = await Mediator.Send(new GetCompaniesListQuery());
            return Ok(vm);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<CompanyDetailsVm>> GetCompanyDetails(int Id)
        {
            var vm = await Mediator.Send(new GetCompanyDetailsQuery() { CompanyId = Id });
            return vm;
        }

        [HttpGet("{Id}/jobs")]
        public async Task<ActionResult<List<CompanyJobOfferVm>>> GetCompanyJobOffers(int Id)
        {
            var vm = await Mediator.Send(new GetCompanyJobOffersQuery() { CompanyId = Id });
            return vm;
        }

    }
}
