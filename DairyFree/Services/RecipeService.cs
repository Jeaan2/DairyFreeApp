using System;
using System.Threading.Tasks;
using DairyFree.Infrastructure.Api;
using DairyFree.Models;

namespace DairyFree.Services
{
    public interface IRecipeService
    {

    }

    public class RecipeService : IRecipeService
    {
        readonly IApiRestful _api;

        public RecipeService(IApiRestful api)
        {
            _api = api;
        }

        public Task<RecipeApiResponse> GetRecipesAsync()
        {
            return _api.GetRecipesAsync(AppConstants.API_KEY);
        }

    }
}
