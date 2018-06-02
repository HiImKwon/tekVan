using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
	public partial class History : ContentPage
	{
	    public double TotalPrice { get; set; } = 0;
        public ObservableCollection<Product> Cart { get; set; } = new ObservableCollection<Product>();

		public History ()
		{
			InitializeComponent ();
		    var price = Application.Current.Properties["Price"];
		    var cart = Application.Current.Properties["Cart"];
		    if (price != null)
		    {
		        TotalPrice = price is double ? (double)price : 0;
		        Cart = (ObservableCollection<Product>)cart;
		    }
		    BindingContext = this;
        }
	}
}