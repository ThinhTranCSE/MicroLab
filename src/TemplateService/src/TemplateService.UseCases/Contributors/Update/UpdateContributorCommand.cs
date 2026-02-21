using TemplateService.Core.ContributorAggregate;

namespace TemplateService.UseCases.Contributors.Update;

public record UpdateContributorCommand(ContributorId ContributorId, ContributorName NewName)
    : ICommand<Result<ContributorDto>>;