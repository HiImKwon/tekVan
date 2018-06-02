using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekVan.Model;
using TekVan.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TekVan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowRoom : ContentPage
    {
        private ShowRoomViewModel _showRoomViewModel;
        public ShowRoom()
        {
            InitializeComponent();
            _showRoomViewModel = new ShowRoomViewModel();
            listView.ItemsSource = ListOfProducts.ProductsList;
        }

        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Product selectedItem = e.Item as Product;
            var ListView = sender as ListView;
            if (ProfileViewModel.GlobalUser == null)
            {
                ProfileViewModel.GlobalUser = new User();
            }
            await Navigation.PushAsync(new Detail(selectedItem, ProfileViewModel.GlobalUser));
            ListView.SelectedItem = null;
        }
    }
}