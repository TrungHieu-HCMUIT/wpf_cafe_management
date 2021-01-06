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
        }

        private void LoadListItems()
        {

        }
    }

    public class Revenue
    {
        public int MaHD { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public Revenue(int maHD, string name, int quantity, int price)
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

        public string Unit { get; set; }

        public int Price { get; set; }

        public Spending(int maHD, string name, string unit, int price)
        {
            MaHD = maHD;
            Name = name;
            Unit = unit;
            Price = price;
        }
    }
}
