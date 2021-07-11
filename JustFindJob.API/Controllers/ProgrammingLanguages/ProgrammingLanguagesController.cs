using JustFindJob.API.Controllers.Common;
using JustFindJob.Application.Features.Companies.Queries.List;
using JustFindJob.Application.Features.ProgrammingLanguages.Queries;
using JustFindJob.Application.Features.ProgrammingLanguages.Queries.FindByName;
using JustFindJob.Application.Features.ProgrammingLanguages.Queries.List;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustFindJob.API.Controllers.ProgrammingLanguages
{
    [Route("api/programmingLanguage/")]
    [ApiController]
    [AllowAnonymous]
    public class ProgrammingLanguagesController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<ProgrammingLanguagesVm>>> List()
        {
            var vm = await Mediator.Send(new GetProgrammingLanguageListQuery());
            return vm;
        }

        [HttpGet("{programmingLanguage}")]
        public async Task<ActionResult<ProgrammingLanguagesVm>> FindByName(string programmingLanguage)
        {
            var vm = await Mediator.Send(new GetProgrammingLanguageByNameQuery() { ProgrammingLangaugeName = programmingLanguage});
            return vm;
        }
    }
}
