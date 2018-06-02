using MvvmHelpers;

namespace TekVan.Model
{
    public class Product :ObservableObject
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _avatar;

        public string Avatar
        {
            get { return _avatar; }
            set { SetProperty(ref _avatar, value); }
        }


        private double _price;

        public double Price
        {
            get { return _price; }
            set { SetProperty(ref _price, value); }
        }

        private string _brand;

        public string Brand
        {
            get { return _brand; }
            set { SetProperty(ref _brand, value); }
        }

        private string _settingDetails;

        public string SettingDetails
        {
            get { return _settingDetails; }
            set { SetProperty(ref _settingDetails, value); }
        }
    }
}