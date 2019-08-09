using System;
using System.Collections.Generic;
using DairyFree.Models;

namespace DairyFree.Repositories
{
    public interface ILocalDataBaseRepository
    {
        void Add(Recipe recipe);
        void Edit(Recipe recipe);
        void Delete(Recipe recipe);


        List<Recipe> GetAll();
        Recipe GetById(string id);
    }
}
