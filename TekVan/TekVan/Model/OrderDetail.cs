using MvvmHelpers;

namespace TekVan.Model
{
    public class OrderDetail : ObservableObject
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private int _productId;

        public int ProductId
        {
            get { return _productId; }
            set { SetProperty(ref _productId, value); }
        }

        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { SetProperty(ref _quantity, value); }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { SetProperty(ref _price, value); }
        }
    }
}