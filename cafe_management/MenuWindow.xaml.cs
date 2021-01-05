using cafe_management.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace cafe_management
{
    /// <summary>
    /// Interaction logic for MenuWindow_1.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        private List<PurchaseItem> PurchaseList = new List<PurchaseItem>();
        public MenuWindow()
        {
            InitializeComponent();

            LoadMenuItems();
        }

        private void changeColorAnimation(Button btn)
        {
            ColorAnimation ca = new ColorAnimation((Color)ColorConverter.ConvertFromString("#EA8025"), new Duration(TimeSpan.FromSeconds(0.3)));
            btn.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, ca);
        }

        private void returnDefaultColor(Button[] btn)
        {
            foreach (Button button in btn)
            {
                button.Foreground = (Brush)new System.Windows.Media.BrushConverter().ConvertFromString("#000000");
            }
        }

        private void CaPheVietNam_Click(object sender, RoutedEventArgs e)
        {
            changeColorAnimation(btnCaPheVietNam);
            Button[] btn = new Button[] { btnCaPheMay, btnDaXay, btnTraTraiCay, btnTraSuaMacchiato };
            returnDefaultColor(btn);

            scrollViewer.ScrollToVerticalOffset(rectCaPheVietNam.TransformToVisual(scrollViewer).Transform(new Point(0, 0)).Y);
        }

        private void CaPheMay_Click(object sender, RoutedEventArgs e)
        {
            changeColorAnimation(btnCaPheMay);
            Button[] btn = new Button[] { btnCaPheVietNam, btnDaXay, btnTraTraiCay, btnTraSuaMacchiato };
            returnDefaultColor(btn);

            scrollViewer.ScrollToVerticalOffset(rectCaPheMay.TransformToVisual(scrollViewer).Transform(new Point(0, 0)).Y);            
        }

        private void DaXay_Click(object sender, RoutedEventArgs e)
        {
            changeColorAnimation(btnDaXay);
            Button[] btn = new Button[] { btnCaPheVietNam, btnCaPheMay, btnTraTraiCay, btnTraSuaMacchiato };
            returnDefaultColor(btn);

            scrollViewer.ScrollToVerticalOffset(rectDaXay.TransformToVisual(scrollViewer).Transform(new Point(0, 0)).Y);
        }

        private void TraTraiCay_Click(object sender, RoutedEventArgs e)
        {
            changeColorAnimation(btnTraTraiCay);
            Button[] btn = new Button[] { btnCaPheVietNam, btnCaPheMay, btnDaXay, btnTraSuaMacchiato };
            returnDefaultColor(btn);

            scrollViewer.ScrollToVerticalOffset(rectTraTraiCay.TransformToVisual(scrollViewer).Transform(new Point(0, 0)).Y);
        }

        private void TraSuaMacchiato_Click(object sender, RoutedEventArgs e)
        {
            changeColorAnimation(btnTraSuaMacchiato);
            Button[] btn = new Button[] { btnCaPheVietNam, btnCaPheMay, btnDaXay, btnTraTraiCay };
            returnDefaultColor(btn);

            scrollViewer.ScrollToVerticalOffset(rectTraSuaMacchiato.TransformToVisual(scrollViewer).Transform(new Point(0, 0)).Y);
        }

        private void dgCoffee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private List<MenuItem> GetMenu(int type)
        {
            List<MenuItem> list = new List<MenuItem>();
            var objectList = DataProvider.Ins.DB.MONs;
            foreach (var item in objectList)
            {
                if (item.MaLoai == type)
                {
                    string source = string.Format("/Resource/MenuWindow/{0}/{1}.jpg", item.MaLoai, item.MaM);
                    MenuItem menuItem = new MenuItem(item.MaM, source, item.TenMon, Convert.ToInt64(item.DonGia));
                    list.Add(menuItem);
                }
            }
            return list;
        }

        private void LoadMenuItems()
        {
            CaPheVietNamListView.ItemsSource = GetMenu(1);
            CaPheMayListView.ItemsSource = GetMenu(2);
            DaXayListView.ItemsSource = GetMenu(3);
            TraTraiCayListView.ItemsSource = GetMenu(4);
            MacchiatoListView.ItemsSource = GetMenu(5);
        }

        private void Add(object sender, MouseButtonEventArgs e)
        {
            StackPanel stackPanel = sender as StackPanel;
            var objectList = DataProvider.Ins.DB.MONs;
            foreach (var item in objectList)
            {
                if (item.MaM == stackPanel.Tag.ToString())
                {
                    PurchaseList.Add(new PurchaseItem(item.MaM, item.TenMon, 1, Convert.ToInt32(item.DonGia)));

                    dgPurchase.ItemsSource = null;
                    dgPurchase.ItemsSource = PurchaseList;
                }
            }
        }
    }

    public class MenuItem
    {
        public string Id { get; set; }

        public string ImagePath { get; set; }

        public string Name { get; set; }

        public long Price { get; set; }
        public int PhanLoai { get; set; }
        public MenuItem(string id, string imagePath, string name, long price)
        {
            Id = id;
            ImagePath = imagePath;
            Name = name;
            Price = price;
        }
    }

    public class PurchaseItem
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public long Quantity { get; set; }

        public int Price { get; set; }

        public PurchaseItem(string id, string name, long quantity, int price)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}

