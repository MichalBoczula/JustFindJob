using JustFindJob.API.Controllers.Common;
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

namespace JustFindJob.API.Controllers.Company
{
    [Route("api/companies")]
    [ApiController]
    [AllowAnonymous]
    public class CompanyController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<CompanyVm>> GetList()
        {
            var vm = await Mediator.Send(new GetCompaniesListQuery());
            return Ok(vm);
        }
    }
}
