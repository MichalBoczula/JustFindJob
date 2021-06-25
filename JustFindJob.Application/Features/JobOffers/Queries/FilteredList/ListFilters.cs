using System.Collections.Generic;

namespace JustFindJob.Application.Features.JobOffers.Queries.FilteredList
{
    public class ListFilters
    {
        public List<string> ProggramingLanguages { get; set; }
        public List<string> ExperienceLevels { get; set; }
     
        public ListFilters()
        {
            ProggramingLanguages = new List<string>();
            ExperienceLevels = new List<string>();
        }
    }
}