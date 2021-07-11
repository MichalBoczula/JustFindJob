using JustFindJob.API.Controllers.Common;
using JustFindJob.Application.Features.TechnologyElements.Queries;
using JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList;
using JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList.FindByProgrammingLanguage;
using JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList.FindByTechnologyName;
using JustFindJob.Application.Features.TechnologyElements.Queries.List;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JustFindJob.API.Controllers.TechnologyElements
{
    [Route("api/technology")]
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

        /// <summary>
        ///  To tests input values should be separate by ',' (coma) like:
        /// programmingLanguages = C#,Java
        /// </summary>
        /// <param name="programmingLanguages"></param>
        /// <returns></returns>
        [HttpGet("/api/technology/programmingLanguages")]
        public async Task<ActionResult<List<FilteredTechnologyElementVm>>> GetFilteredListByProggramingLanguage(string programmingLanguages)
        {
            var filters = new ListFiltersTechnologyElement();
            filters.AddProgrammingLanguages(programmingLanguages);
            var vm = await Mediator.Send(new GetTechnologyElementFilteredListByLanguageQuery() { Filters = filters });
            return vm;
        }

        /// <summary>
        ///  To tests input values should be separate by ',' (coma) like:
        /// technologyNames = Angular,MSSQL
        /// </summary>
        /// <param name="technologyNames"></param>
        /// <returns></returns>
        [HttpGet("/api/technology/technologyNames")]
        public async Task<ActionResult<List<FilteredTechnologyElementVm>>> GetFilteredListByTechnologyName(string technologyNames)
        {
            var filters = new ListFiltersTechnologyElement();
            filters.AddTechnologyNames(technologyNames);
            var vm = await Mediator.Send(new GetTechnologyElementFilteredListByNameQuery() { Filters = filters });
            return vm;
        }
    }
}

