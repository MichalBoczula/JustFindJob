using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList
{
    public class ListFiltersTechnologyElement
    {
        public List<string> TechnologyNames { get; set; }
        public List<string> ProgrammingLanguages { get; set; }

        public ListFiltersTechnologyElement()
        {
            TechnologyNames = new List<string>();
            ProgrammingLanguages = new List<string>();
        }

        public void AddTechnologyNames(string names)
        {
            if (!string.IsNullOrWhiteSpace(names))
            {
                var eles = names.Split(",");
                TechnologyNames.AddRange(eles);
            }
        }

        public void AddProgrammingLanguages(string languages)
        {
            if (!string.IsNullOrWhiteSpace(languages))
            {
                var eles = languages.Split(",");
                ProgrammingLanguages.AddRange(eles);
            }
        }
    }
}
