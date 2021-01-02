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
        //public List<MenuItem> CaPheVietNamItems;
        //public List<MenuItem> CaPheMayItems;
        //public List<MenuItem> DaXayItems;
        //public List<MenuItem> TraTraiCayItems;
        //public List<MenuItem> MacchiatoItems;

        public MenuWindow()
        {
            InitializeComponent();

            //CaPheVietNamItems = GetCaPheVietNamItems();
            //CaPheMayItems = GetCaPheMayItems();
            //DaXayItems = GetDaXayItems();
            //TraTraiCayItems = GetTraTraiCayItems();
            //MacchiatoItems = GetMacchiatoItems();

            //LoadMenuItems();
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
                button.Foreground = (Brush) new System.Windows.Media.BrushConverter().ConvertFromString("#000000");
            }
        }

        private void CaPheVietNam_Click(object sender, RoutedEventArgs e)
        {
            //changeColorAnimation(btnCaPheVietNam);
            //Button[] btn = new Button[] { btnCaPheMay, btnDaXay, btnTraTraiCay, btnTraSuaMacchiato };
            //returnDefaultColor(btn);

            //scrollViewer.ScrollToVerticalOffset(rectCaPheVietNam.TransformToVisual(scrollViewer).Transform(new Point(0, 0)).Y);
        }

        private void CaPheMay_Click(object sender, RoutedEventArgs e)
        {
            //changeColorAnimation(btnCaPheMay);
            //Button[] btn = new Button[] { btnCaPheVietNam, btnDaXay, btnTraTraiCay, btnTraSuaMacchiato };
            //returnDefaultColor(btn);

            //scrollViewer.ScrollToVerticalOffset(rectCaPheMay.TransformToVisual(scrollViewer).Transform(new Point(0, 0)).Y);            
        }

        private void DaXay_Click(object sender, RoutedEventArgs e)
        {
            //changeColorAnimation(btnDaXay);
            //Button[] btn = new Button[] { btnCaPheVietNam, btnCaPheMay, btnTraTraiCay, btnTraSuaMacchiato };
            //returnDefaultColor(btn);

            //scrollViewer.ScrollToVerticalOffset(rectDaXay.TransformToVisual(scrollViewer).Transform(new Point(0, 0)).Y);
        }

        private void TraTraiCay_Click(object sender, RoutedEventArgs e)
        {
            //changeColorAnimation(btnTraTraiCay);
            //Button[] btn = new Button[] { btnCaPheVietNam, btnCaPheMay, btnDaXay, btnTraSuaMacchiato };
            //returnDefaultColor(btn);

            //scrollViewer.ScrollToVerticalOffset(rectTraTraiCay.TransformToVisual(scrollViewer).Transform(new Point(0, 0)).Y);
        }

        private void TraSuaMacchiato_Click(object sender, RoutedEventArgs e)
        {
            //changeColorAnimation(btnTraSuaMacchiato);
            //Button[] btn = new Button[] { btnCaPheVietNam, btnCaPheMay, btnDaXay, btnTraTraiCay };
            //returnDefaultColor(btn);

            //scrollViewer.ScrollToVerticalOffset(rectTraSuaMacchiato.TransformToVisual(scrollViewer).Transform(new Point(0, 0)).Y);
        }

        //Item change event
        private void dgCoffee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
     
    //    private List<MenuItem> GetCaPheMayItems()
    //    {
    //        return new List<MenuItem>
    //        {
    //            new MenuItem("1001", "/Resource/MenuWindow/Cà phê máy/Americano.jpg", "Cà phê sữa", 20000),
    //            new MenuItem("1002", "/Resource/MenuWindow/Cà phê máy/Cappucino.jpg", "Cà phê sữa", 25000),
    //            new MenuItem("1002", "/Resource/MenuWindow/Cà phê máy/Caramel Macchiato.jpg", "Cà phê sữa", 25000),
    //            new MenuItem("1002", "/Resource/MenuWindow/Cà phê máy/Espresso.jpg", "Cà phê sữa", 25000),
    //            new MenuItem("1002", "/Resource/MenuWindow/Cà phê máy/Latte.jpg", "Cà phê sữa", 25000),
    //            new MenuItem("1002", "/Resource/MenuWindow/Cà phê máy/Mocha.jpg", "Cà phê sữa", 25000)
    //        };
    //    }

    //    private List<MenuItem> GetDaXayItems()
    //    {
    //        return new List<MenuItem>
    //        {
    //            new MenuItem("1001", "/Resource/MenuWindow/Đá xay/Phúc bồn tử.jpg", "Cà phê đen", 20000),
    //            new MenuItem("1001", "/Resource/MenuWindow/Đá xay/Sữa tươi Macchiato.jpg", "Cà phê đen", 20000),
    //            new MenuItem("1002", "/Resource/MenuWindow/Đá xay/Sữa tươi.jpg", "Cà phê sữa", 25000),
    //            new MenuItem("1003", "/Resource/MenuWindow/Đá xay/Truyền thống.jpg", "Bạc xỉu", 29000)
    //        };
    //    }

    //    private List<MenuItem> GetTraTraiCayItems()
    //    {
    //        return new List<MenuItem>
    //        {
    //            new MenuItem("1001", "/Resource/MenuWindow/Trà trái cây/Trà đào cam sả.jpg", "Cà phê đen", 20000),
    //            new MenuItem("1002", "/Resource/MenuWindow/Trà trái cây/Trà hạt sen.jpg", "Cà phê sữa", 25000),
    //            new MenuItem("1002", "/Resource/MenuWindow/Trà trái cây/Trà phúc bồn tử.jpg", "Cà phê sữa", 25000),
    //            new MenuItem("1003", "/Resource/MenuWindow/Trà trái cây/Trà vải.jpg", "Bạc xỉu", 29000)
    //        };
    //    }

    //    private List<MenuItem> GetMacchiatoItems()
    //    {
    //        return new List<MenuItem>
    //        {
    //            new MenuItem("1001", "/Resource/MenuWindow/Trà sữa Macchiato/Trà đen Macchiato.jpg", "Cà phê đen", 20000),
    //            new MenuItem("1001", "/Resource/MenuWindow/Trà sữa Macchiato/Trà lài Macchiato.jpg", "Cà phê đen", 20000),
    //            new MenuItem("1001", "/Resource/MenuWindow/Trà sữa Macchiato/Trà Matcha Macchiato.jpg", "Cà phê đen", 20000),
    //            new MenuItem("1002", "/Resource/MenuWindow/Trà sữa Macchiato/Trà sữa trân châu.jpg", "Cà phê sữa", 25000),
    //            new MenuItem("1003", "/Resource/MenuWindow/Trà sữa Macchiato/Trà xoài Macchiato.jpg", "Bạc xỉu", 29000)
    //        };
    //    }

    //    private void LoadMenuItems()
    //    {
    //        CaPheVietNamListView.ItemsSource = CaPheVietNamItems;
    //        CaPheMayListView.ItemsSource = CaPheMayItems;
    //        DaXayListView.ItemsSource = DaXayItems;
    //        TraTraiCayListView.ItemsSource = TraTraiCayItems;
    //        MacchiatoListView.ItemsSource = MacchiatoItems;
    //    }
    //}

    //public class MenuItem //Tạo lớp đối tượng riêng dùm má :((
    //{
    //    public string Id { get; set; }

    //    public string ImagePath { get; set; }

    //    public string Name { get; set; }

    //    public int Price { get; set; }
    //    public int PhanLoai { get; set; }
    //    public MenuItem(string id, string imagePath, string name, int price)
    //    {
    //        Id = id;
    //        ImagePath = imagePath;
    //        Name = name;
    //        Price = price;
    //    }
    }
}
