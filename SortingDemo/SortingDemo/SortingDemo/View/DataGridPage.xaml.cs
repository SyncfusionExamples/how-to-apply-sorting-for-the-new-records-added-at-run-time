using Syncfusion.Data;
using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SortingDemo
{
    public partial class DataGridPage : ContentPage
    {
        ViewModel viewModel;
        public DataGridPage()
        {
            InitializeComponent();
            viewModel = new ViewModel();
            dataGrid.ItemsSource = viewModel.OrdersInfo;
            dataGrid.AllowSorting = true;
            dataGrid.GridLoaded += DataGrid_GridLoaded;
            dataGrid.SortColumnDescriptions.Add(new SortColumnDescription() { ColumnName = "EmployeeID",SortDirection=ListSortDirection.Descending });
        }

        private void DataGrid_GridLoaded(object sender, GridLoadedEventArgs e)
        {
            dataGrid.LiveDataUpdateMode = LiveDataUpdateMode.AllowDataShaping;
        }

        private void AddItem_Clicked(object sender, EventArgs e)
        {
            viewModel.OrdersInfo.Add(new OrderInfo(58, 1796, "Linod", "Michael", "Mendoza"));
            viewModel.OrdersInfo.Add(new OrderInfo(50, 1794, "Furib", "Danielle", "Keefe"));
            viewModel.OrdersInfo.Add(new OrderInfo(51, 1794, "Folko", "William", "Owens"));
            viewModel.OrdersInfo.Add(new OrderInfo(56, 1787, "Blonp", "Brenda", "Betts"));
        }
    }
}