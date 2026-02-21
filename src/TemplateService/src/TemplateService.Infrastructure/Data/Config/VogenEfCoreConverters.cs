using TemplateService.Core.ContributorAggregate;
using Vogen;

namespace TemplateService.Infrastructure.Data.Config;

[EfCoreConverter<ContributorId>]
[EfCoreConverter<ContributorName>]
internal partial class VogenEfCoreConverters;