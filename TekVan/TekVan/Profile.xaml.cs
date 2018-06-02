using System;
using TekVan.Model;
using TekVan.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TekVan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        

        private readonly ProfileViewModel _profileViewModel;
        public Profile()
        {
            InitializeComponent();
            BindingContext = _profileViewModel = new ProfileViewModel();
            LoginSucceed.IsVisible = false;
        }

        private async void SignIn_Clicked(object sender, EventArgs e)
        {
            var checkLogin= await _profileViewModel.DoLoginAsync();
            if (checkLogin)
            {
                Login.IsVisible = false;
                LoginSucceed.IsVisible = true;
                
            }
            else
            {
                await DisplayAlert("Access Denied", "Your Username or Password is not correct!", "OK");
            }
        }

        private async void SignUp_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SignUp());
        }

        private void LogOut_OnClicked(object sender, EventArgs e)
        {
            Login.IsVisible = true;
            LoginSucceed.IsVisible = false;
            _profileViewModel.UserViewModel.Username = "";
            _profileViewModel.UserViewModel.Password = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            _profileViewModel.User = null;
            ProfileViewModel.GlobalUser = null;
        }


        private async void HistoryButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new History());
        }
    }
}