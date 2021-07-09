using JustFindJob.Domain.Entities;
using System.Collections.Generic;

namespace JustFindJob.Application.Features.JobOffers.Queries.FilteredList
{
    public class ListFilters
    {
        public List<string> ProggramingLanguages { get; set; }
        public List<ExperienceLevels> ExpLevels { get; set; }
        public List<string> Localizations { get; set; }

        public ListFilters()
        {
            ProggramingLanguages = new List<string>();
            ExpLevels = new List<ExperienceLevels>();
            Localizations = new List<string>();
        }

        public void AddProggramingLanguages(string languages)
        {
            if (!string.IsNullOrWhiteSpace(languages))
            {
                var elements = languages.Split(",");
                ProggramingLanguages.AddRange(elements);
            }
        }

        public void AddExperienceLevels(string expLeveles)
        {
            if (!string.IsNullOrWhiteSpace(expLeveles))
            {
                var elements = expLeveles.Split(",");
                foreach (var ele in elements)
                {
                    switch (ele)
                    {
                        case "Junior":
                            ExpLevels.Add(ExperienceLevels.Junior);
                            break;
                        case "Mid":
                            ExpLevels.Add(ExperienceLevels.Mid);
                            break;
                        case "Senior":
                            ExpLevels.Add(ExperienceLevels.Senior);
                            break;
                    }
                }
            }
        }

        public void AddLocalizations(string localizations)
        {
            if (!string.IsNullOrWhiteSpace(localizations))
            {
                var elements = localizations.Split(",");
                Localizations.AddRange(elements);
            }
        }
    }
}