using System.Collections.Generic;
using MvvmHelpers;

namespace TekVan.Model
{
    public class Order : ObservableObject
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _userId;

        public string UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        private List<OrderDetail> _orderDetailId;

        public List<OrderDetail> OrderDetailList
        {
            get { return _orderDetailId; }
            set { SetProperty(ref _orderDetailId, value); }
        }

        private double _totalPrice;

        public double TotalPrice
        {
            get { return _totalPrice; }
            set { SetProperty(ref _totalPrice, value); }
        }


    }
}