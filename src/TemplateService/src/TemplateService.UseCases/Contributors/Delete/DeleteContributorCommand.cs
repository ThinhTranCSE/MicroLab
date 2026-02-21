using TemplateService.Core.ContributorAggregate;

namespace TemplateService.UseCases.Contributors.Delete;

public record DeleteContributorCommand(ContributorId ContributorId) : ICommand<Result>;