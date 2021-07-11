using JustFindJob.Domain.Entities;

namespace JustFindJob.Application.Features.TechnologyElements.Queries.List
{
    public class TechStackVm
    {
        public TechnologyElementForTechnologyElementListDto TechnologyElementDto { get; set; }
        public ProgrammingLanguageForTechnologyElementListDto ProgrammingLanguageDto { get; set; }
    }
}