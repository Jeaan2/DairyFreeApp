using System;
using System.Threading.Tasks;
using DairyFree.Models;
using Refit;

namespace DairyFree.Infrastructure.Api
{
    [Headers("Content-Type: application/json")]
    public interface IApiRestful
    {
        [Get("recipes/search?intolerances=dairy?")]
        Task<RecipeApiResponse> GetRecipesAsync(string apiKey);



    }
}
