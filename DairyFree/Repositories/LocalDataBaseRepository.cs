using System;
using System.Collections.Generic;
using System.Linq;
using DairyFree.Models;
using DairyFree.Services;
using LiteDB;

namespace DairyFree.Repositories
{
    public class LocalDataBaseRepository : ILocalDataBaseRepository
    {

        private const string COLLECTION_NAME = "recipies";


        private readonly LiteCollection<Recipe> liteCollection;
        private readonly IDataBaseAccessService dataBaseAccessService;

        public LocalDataBaseRepository(IDataBaseAccessService dataBaseAccessService)
        {
            this.dataBaseAccessService = dataBaseAccessService;
            liteCollection = GetCollection();
        }

        public void Add(Recipe recipe)
            => liteCollection.Insert(recipe);

        public void Delete(Recipe recipe)
            => liteCollection.Delete(recipe.Id);

        public void Edit(Recipe recipe)
            => liteCollection.Update(recipe);

        public List<Recipe> GetAll()
            => liteCollection.FindAll().ToList();

        public Recipe GetById(string id)
            => liteCollection.FindById(id);

        private LiteCollection<Recipe> GetCollection()
        {
            var db = GetOrCreateLiteDatabase();
            return db.GetCollection<Recipe>(COLLECTION_NAME);
        }

        private LiteDatabase GetOrCreateLiteDatabase()
        {
            var dbPath = dataBaseAccessService.GetDataBasePath();
            return new LiteDatabase($@"{dbPath}");
        }
    }


}
