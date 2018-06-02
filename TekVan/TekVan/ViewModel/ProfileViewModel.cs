using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmHelpers;
using SQLite;
using TekVan.Model;
using TekVan.Repository;
using TekVan.Service;
using Xamarin.Forms;

namespace TekVan.ViewModel
{
    public class UserViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class ProfileViewModel : BaseViewModel
    {
        //private readonly SQLiteAsyncConnection _connection;

        //private readonly UnitOfWork _unitOfWork;

        public UserViewModel UserViewModel { get; set; }

        public ListOfUser ListOfUsers { get; set; }
        public static User GlobalUser { get; set; }
        public static Order UserOrder { get; set; }
        public static OrderDetail orderDetail { get; set; }
        public static int DetailIndex { get; set; }

        public static ObservableCollection<Product> Cart { get; set; }
        

        private User _user;

        public User User
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }





        public ProfileViewModel()
        {
            UserViewModel = new UserViewModel()
            {
                Username = "",
                Password = ""
            };
            User = new User();
           
            ListOfUsers=new ListOfUser();
            //_connection = DependencyService.Get<ISQLiteConnectionService>().GetConnection();
            //_unitOfWork=new UnitOfWork(_connection);
            //_unitOfWork.Users.Add(user);
        }

        public async Task<bool> DoLoginAsync()
        {
            bool checkLogin = false;
            foreach (var item in ListOfUser.UserList)
            {
                if (item.Id.Equals(UserViewModel.Username) 
                    && item.Password.Equals(UserViewModel.Password))
                {
                    User = item;
                    GlobalUser = User;
                    checkLogin = true;
                    UserOrder = new Order
                    {
                        Id = 1,
                        OrderDetailList = new List<OrderDetail>(),
                        TotalPrice = 0,
                        UserId = GlobalUser.Id
                    };
                    orderDetail = new OrderDetail();
                    DetailIndex = 0;
                    Cart=new ObservableCollection<Product>();
                    Application.Current.Properties["Price"] = UserOrder.TotalPrice;
                    Application.Current.Properties["Cart"] = Cart;
                }
            }
            return checkLogin;

        }
    }
}