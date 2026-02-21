using TemplateService.Core.ContributorAggregate;

namespace TemplateService.UseCases.Contributors.Get;

public record GetContributorQuery(ContributorId ContributorId) : IQuery<Result<ContributorDto>>;