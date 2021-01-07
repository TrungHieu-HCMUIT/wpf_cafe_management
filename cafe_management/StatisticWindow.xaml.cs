using cafe_management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace cafe_management
{
    /// <summary>
    /// Interaction logic for StatisticWindow.xaml
    /// </summary>
    public partial class StatisticWindow : Window
    {
        private List<Revenue> revenue = new List<Revenue>();
        private List<Spending> spending = new List<Spending>();
        public StatisticWindow()
        {
            InitializeComponent();

            LoadListItems();
            LoadSpendingListItems();
            LoadMoney();
        }

        private void LoadMoney()
        {
            int total_revenue = 0;
            int total_spending = 0;
            for (int i = 0; i < revenue.Count; i++)
            {
                total_revenue += (int)revenue[i].Price;
            }

            for (int i = 0; i < spending.Count; i++)
            {
                total_spending += (int)spending[i].Price;
            }
            tbRevenue.Text = "Tổng thu: " + total_revenue;
            tbSpending.Text = "Tổng chi: " + total_spending;
            tbTotal.Text = "DOANH THU NGÀY: " + (total_revenue - total_spending);
        }

        private List<Revenue> GetRevenue()
        {
            List<Revenue> list = new List<Revenue>();
            var objectList = DataProvider.Ins.DB.CTHDs;
            foreach (var item in objectList)
            {
                Revenue revenue = new Revenue(item.MaHD, item.MON.TenMon, item.SL, Convert.ToInt64(item.MON.DonGia * item.SL));
                list.Add(revenue);
            }
            return list;
        }
        private void LoadListItems()
        {
            dgRevenue.ItemsSource = revenue = GetRevenue();
        }

        private List<Spending> GetSpending()
        {
            List<Spending> list = new List<Spending>();
            var objectList = DataProvider.Ins.DB.CTPCs;
            foreach (var item in objectList)
            {
                Spending spending = new Spending(item.MaPC, item.NGUYENLIEU.TenNgL, item.SL, item.NGUYENLIEU.DonVi, Convert.ToInt64(item.NGUYENLIEU.DonGia));
                list.Add(spending);
            }
            return list;
        }

        private void LoadSpendingListItems()
        {
            dgSpending.ItemsSource = spending = GetSpending();
        }

        private void Terminate_Click(object sender, RoutedEventArgs e)
        {
            StaffWindow staffWindow = new StaffWindow();
            staffWindow.Show();
            this.Close();
        }

        private void Display_Click(object sender, RoutedEventArgs e)
        {
            if (dpTime.SelectedDate == null)
                return;
            int day = dpTime.SelectedDate.Value.Day;
            int month = dpTime.SelectedDate.Value.Month;
            int year = dpTime.SelectedDate.Value.Year;
        }
    }

    public class Revenue
    {

        public int MaHD { get; set; }

        public string Name { get; set; }

        public int? Quantity { get; set; }

        public long Price { get; set; }

        public Revenue(int maHD, string name, int? quantity, long price)
        {
            MaHD = maHD;
            Name = name;
            Quantity = quantity;
            Price = price;
        }

    }

    public class Spending
    {
        public int MaHD { get; set; }

        public string Name { get; set; }

        public int? Quantity { get; set; }
        public string Unit { get; set; }

        public long Price { get; set; }

        public Spending(int maHD, string name, int? quantity, string unit, long price)
        {
            MaHD = maHD;
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Price = price;
        }
    }
}