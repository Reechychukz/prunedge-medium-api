using Application.Helpers;
using Microsoft.Extensions.Localization;

namespace Application.Resources
{
    public interface IValidationLocalizerService : IAutoDependencyService
    {
        LocalizedString GetLocalizedString(string key);
    }
}
