using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemo
{
    public class OrderInfoRepository
    {
        private ObservableCollection<OrderInfo> orderInfo;

        public OrderInfoRepository()
        {
            orderInfo = new ObservableCollection<OrderInfo>();
        }

        public ObservableCollection<OrderInfo> GenerateOrders()
        {
            orderInfo.Add(new OrderInfo(48, 1795, "Folka", "Katie", "Owens"));
            orderInfo.Add(new OrderInfo(38, 1791,"Linod","Michael","Keefe"));
            orderInfo.Add(new OrderInfo(49, 1791, "Alfki", "Michael", "Adams"));
            orderInfo.Add(new OrderInfo(10, 1785, "Merep", "Michael", "Adams"));
            orderInfo.Add(new OrderInfo(3,  1783, "Folko", "Michael", "Waddell"));
            orderInfo.Add(new OrderInfo(26, 1782, "Furib", "Willam", "Betts"));
            orderInfo.Add(new OrderInfo(39, 1782, "Folko", "Brenda", "Keefe"));
            orderInfo.Add(new OrderInfo(31, 1777, "Vaffe", "Irene", "Doran"));
            return orderInfo;
        }
    }
}
