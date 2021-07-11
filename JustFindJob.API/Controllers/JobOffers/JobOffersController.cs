using JustFindJob.API.Controllers.Common;
using JustFindJob.Application.Features.JobOffers.Queries.Details;
using JustFindJob.Application.Features.JobOffers.Queries.FilteredList;
using JustFindJob.Application.Features.JobOffers.Queries.List;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustFindJob.API.Controllers.JobOffers
{
    [Route("api/jobs")]
    [AllowAnonymous]
    public class JobOffersController : BaseController
    {
        [HttpGet("{Id}")]
        public async Task<ActionResult<JobOfferDetailsVm>> GetDetails(int Id)
        {
            var vm = await Mediator.Send(new GetJobOfferDetailsQuery() { JobOfferId = Id });
            return Ok(vm);
        }

        /// <summary>
        /// To tests input values should be separate by ',' (coma) like:
        /// languages = C#,Java
        /// localizations = Warsaw,Wroclaw,Crakow
        /// expLevels = Junior,Mid;
        /// </summary>
        /// <param name="languages"></param>
        /// <param name="localizations"></param>
        /// <param name="expLevels"></param>
        /// <returns></returns>
        [HttpGet("/api/jobs/search")]
        public async Task<ActionResult<FilteredJobOfferListVm>> GetFilteredJobs(string languages, string localizations, string expLevels)
        {
            var filters = new ListFiltersJobOffer();
            filters.AddProggramingLanguages(languages);
            filters.AddLocalizations(localizations);
            filters.AddExperienceLevels(expLevels);
            var vm = await Mediator.Send(new GetFilteredJobOfferListQuery() { Filters = filters });
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
