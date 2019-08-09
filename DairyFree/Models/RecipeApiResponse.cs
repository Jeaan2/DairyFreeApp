using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DairyFree.Models
{
    public class RecipeApiResponse
    {

        [JsonProperty("results")]
        public IEnumerable<RecipeItemReponse> Recipes { get; set; }


    }
}
