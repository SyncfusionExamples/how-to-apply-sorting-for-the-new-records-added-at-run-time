using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        private int orderID;
        private string customerID;
        private int employeeID;
        private string firstname;
        private string lastname;

        public int OrderID
        {
            get { return orderID; }
            set
            {
                this.orderID = value;
                RaisePropertyChanged("OrderID");
            }
        }
         
        public int EmployeeID
        {
            get { return employeeID; }
            set
            {
                this.employeeID = value;
                RaisePropertyChanged("EmployeeID");
            }
        }
        public string CustomerID
        {
            get { return customerID; }
            set
            {
                this.customerID = value;
                RaisePropertyChanged("CustomerID");
            }
        }

        public string FirstName
        {
            get { return firstname; }
            set
            {
                this.firstname = value;
                RaisePropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return this.lastname; }
            set
            {
                this.lastname = value;
                RaisePropertyChanged("LastName");
            }
        }

        public OrderInfo(int orderId, int employeeId, string customerId, string firstname, string lastname)
        {
            this.OrderID = orderId;
            this.EmployeeID = employeeId;
            this.CustomerID = customerId;
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
