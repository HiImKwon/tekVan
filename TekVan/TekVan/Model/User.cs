using MvvmHelpers;

namespace TekVan.Model
{
    public class User:ObservableObject
    {
        private string _id;
        public string Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _password;


        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
    }
}