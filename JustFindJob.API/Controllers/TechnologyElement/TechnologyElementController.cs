using JustFindJob.API.Controllers.Common;
using JustFindJob.Application.Features.TechnologyElements.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustFindJob.API.Controllers.TechnologyElement
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class TechnologyElementController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<TechStackVm>>> GetList()
        {
            var vm = await Mediator.Send(new GetTechnologyElementListQuery());
            return vm;
        }
    }
}
