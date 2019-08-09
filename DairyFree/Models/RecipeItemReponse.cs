using System;
using Newtonsoft.Json;

namespace DairyFree.Models
{
    public class RecipeItemReponse
    {

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("readyInMinutes")]
        public int ReadyInMinutes { get; set; }

        [JsonProperty("servings")]
        public int Servings { get; set; }
    }
}
