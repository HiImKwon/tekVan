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
	public partial class SignUp : ContentPage
	{
	    
		public SignUp ()
		{
			InitializeComponent ();
		}

	    private async Task SignUp_OnClicked(object sender, EventArgs e)
	    {
	        User user = new User
	        {
	            Id = txtUsername.Text,
	            Password = txtPassword.Text,
	            Address = txtAddress.Text,
	            Email = txtEmail.Text
	        };
	        bool checkValid = true;
	        foreach (var item in ListOfUser.UserList)
	        {
	            if (item.Id.Equals(user.Id))
	            {
	                checkValid = false;
	            }
	        }
	        if (!checkValid)
	        {
	            await DisplayAlert("Message", "Sorry, the username has been used!", "OK");
	            txtUsername.Text = "";
	            txtPassword.Text = "";
	            txtAddress.Text = "";
	            txtEmail.Text = "";

	        }
	        else
	        {
                ListOfUser.UserList.Add(user);
	            await DisplayAlert("Message", "Thank you for your registration!", "OK");
            }

	    }

	    private async void BackButton_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PopModalAsync();
        }
	}
}