using System;
using System.IO;
using SQLite;
using TekVan.Service;

namespace TekVan.Droid.Service
{
    class SQLiteConnectionServiceAndroid: ISQLiteConnectionService
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var fileName = "realTekVan.db3";
            var documentPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentPath, fileName);
            return new SQLiteAsyncConnection(filePath);
        }
    }
}