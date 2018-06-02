
using System.Collections.ObjectModel;

namespace TekVan.Model
{
    public class ListOfUser
    {
        public static ObservableCollection<User> UserList { get; set; }

        public ListOfUser()
        {
            UserList = new ObservableCollection<User>
            {
                new User
                {
                    Id = "buiquan2710",
                    Password = "buiquan1997",
                    Address = "201 H3 Chu Van An Apartment",
                    Email = "buikhacminhquan@hotmail.com"
                }
            };
        }


    }
}