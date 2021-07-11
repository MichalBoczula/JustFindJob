using JustFindJob.API.Controllers.Common;
using JustFindJob.Application.Features.TechnologyElements.Queries;
using JustFindJob.Application.Features.TechnologyElements.Queries.List;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustFindJob.API.Controllers.TechnologyElements
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class TechnologyElementsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<TechnologyElementVm>>> GetList()
        {
            var vm = await Mediator.Send(new GetTechnologyElementListQuery());
            return vm;
        }
    }
}
