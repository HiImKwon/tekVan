using System.IO;
using SQLite;
using TekVan.Service;

namespace TekVan.iOS.Service
{
    public class ISQLiteConnectionServiceApple :ISQLiteConnectionService
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var fileName = "realTekVan.db3";
            var documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var filePath = Path.Combine(documentPath, fileName);
            return new SQLiteAsyncConnection(filePath);
        }
    }
}