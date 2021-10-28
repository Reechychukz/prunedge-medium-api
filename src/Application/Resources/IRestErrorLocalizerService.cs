using Application.Helpers;
using Microsoft.Extensions.Localization;

namespace Application.Resources
{
    public interface IRestErrorLocalizerService : IAutoDependencyService
    {
        LocalizedString GetLocalizedString(string key);
    }
}
