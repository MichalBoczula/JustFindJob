namespace JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList.FindByProgrammingLanguage
{
    public class FilteredTechnologyElementVm
    {
        public TechnologyElementForTechnologyElementFilteredListDto TechnologyElementDto { get; set; }
        public ProgrammingLanguageForTechnologyElementFilteredListDto ProgrammingLanguageDto { get; set; }
    }
}