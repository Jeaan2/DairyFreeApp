using System;
namespace DairyFree.Models
{
    public class Ingredient : BaseModel
    {
       public string Name { get; set; }
       public string Amount { get; set; }
       public int Unit { get; set; }

    }
}
