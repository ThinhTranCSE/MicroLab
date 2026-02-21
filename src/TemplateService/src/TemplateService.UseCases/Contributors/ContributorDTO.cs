using TemplateService.Core.ContributorAggregate;

namespace TemplateService.UseCases.Contributors;

public record ContributorDto(ContributorId Id, ContributorName Name, PhoneNumber PhoneNumber);