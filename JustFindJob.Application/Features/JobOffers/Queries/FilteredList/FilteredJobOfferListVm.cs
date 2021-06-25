namespace JustFindJob.Application.Features.JobOffers.Queries.FilteredList
{
    public class FilteredJobOfferListVm
    {
        public JobOfferForFilteredListDto JobOfferDto { get; set; }
        public CompanyForFilteredJobOfferDto CompanyDto { get; set; }
        public ProgrammingLanguageForFilteredListDto ProgrammingLanguageDto { get; set; }
    }
}