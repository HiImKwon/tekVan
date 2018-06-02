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
    public partial class Detail : ContentPage
    {
        private readonly Product selectedProduct;
        private readonly User selectedUser;

        public Detail( Product selectedItem, User user)
        {
            InitializeComponent();
            selectedProduct = selectedItem;
            selectedUser = user;
            BindingContext = selectedProduct;
            if (selectedUser.Id == null)
            {
                btnAction.BackgroundColor = Color.LightGray;
                btnAction.IsEnabled = false;
            }
            else
            {
                btnAction.BackgroundColor = Color.Crimson;
                btnAction.IsEnabled = true;
            }
        }

        private void BtnAction_OnClicked(object sender, EventArgs e)
        {
            bool checkExist = false;
                for (int i = 0; i < ProfileViewModel.UserOrder.OrderDetailList.Count; i++)
                {
                    if (selectedProduct.Id == ProfileViewModel.UserOrder.OrderDetailList[i].ProductId)
                    {
                        ProfileViewModel.UserOrder.OrderDetailList[i].Quantity += 1;
                        ProfileViewModel.Cart.Add(selectedProduct);
                        ProfileViewModel.UserOrder.TotalPrice += selectedProduct.Price;
                        checkExist = true;
                    }
                }
                
                if (!checkExist)
                {
                    OrderDetail detail = new OrderDetail
                    {
                        Id = ProfileViewModel.DetailIndex,
                        Price = selectedProduct.Price,
                        ProductId = selectedProduct.Id,
                        Quantity = 1
                    };
                    ProfileViewModel.DetailIndex++;
                    ProfileViewModel.UserOrder.OrderDetailList.Add(detail);
                    ProfileViewModel.Cart.Add(selectedProduct);
                    ProfileViewModel.UserOrder.TotalPrice += selectedProduct.Price;
                    
                }
            
            Application.Current.Properties["Price"] = ProfileViewModel.UserOrder.TotalPrice;
            Application.Current.Properties["Cart"] = ProfileViewModel.Cart;
            DisplayAlert("Message", "Thank you for your order, we will contact to confirm your cart. Have a nice day!",
                "OK");

        }
    }
}