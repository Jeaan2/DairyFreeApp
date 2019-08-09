using System;
using System.IO;
using DairyFree.Services;

namespace DairyFree.Droid.Services
{
    public class DataBaseAccessService : IDataBaseAccessService
    {
        public string GetDataBasePath()
        {
            var path = Path.Combine(System.Environment
                .GetFolderPath(System.Environment.SpecialFolder.Personal),
                AppConstants.OFFLINE_DATABASE_NAME);

            if (!File.Exists(path))
                File.Create(path).Dispose();

            return path;
        }
    }

}
