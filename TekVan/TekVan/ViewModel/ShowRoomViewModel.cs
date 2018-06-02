using MvvmHelpers;
using SQLite;
using TekVan.Model;
using TekVan.Repository;
using TekVan.Service;
using Xamarin.Forms;

namespace TekVan.ViewModel
{
    public class ShowRoomViewModel :BaseViewModel
    {
        //private readonly SQLiteAsyncConnection _connection;
        //private readonly UnitOfWork _unitOfWork;
        private ListOfProducts ProductList;

        public ShowRoomViewModel()
        {
            //_connection = DependencyService.Get<ISQLiteConnectionService>().GetConnection();
            //_unitOfWork = new UnitOfWork(_connection);
            ProductList = new ListOfProducts();
        }
    }
}