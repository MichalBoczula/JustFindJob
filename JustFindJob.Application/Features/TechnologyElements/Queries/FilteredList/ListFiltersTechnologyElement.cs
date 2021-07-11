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
    }
}
