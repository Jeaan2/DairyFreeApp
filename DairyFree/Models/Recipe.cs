using System;
using System.Collections.Generic;

namespace DairyFree.Models
{
    public class Recipe : BaseModel
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public int ReadyInMinutes { get; set; }
        public int Servings { get; set; }
    }
}
