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
        public MenuWindow()
        {
            InitializeComponent();

            List<Coffee> coffee = new List<Coffee>();
            coffee.Add(new Coffee() { Name = "Cà phê sữa", Quantity = 1, Price = 25000 });
            coffee.Add(new Coffee() { Name = "Cà phê đen", Quantity = 2, Price = 20000 });
            coffee.Add(new Coffee() { Name = "Bạc xỉu", Quantity = 1, Price = 27000 });
            dgCoffee.ItemsSource = coffee;
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

        //Item change event
        private void dgCoffee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //Test

    }

    public class Coffee
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }
    }
}
