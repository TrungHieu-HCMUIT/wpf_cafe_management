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
    /// Interaction logic for MenuWindow_1.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void CaPheVietNam_Click(object sender, RoutedEventArgs e)
        {
            scrollViewer.ScrollToVerticalOffset(rectCaPheVietNam.TransformToVisual(scrollViewer).TransformBounds(new Rect(0, 0, 0, 0)).Top);
        }

        private void CaPheMay_Click(object sender, RoutedEventArgs e)
        {
            scrollViewer.ScrollToVerticalOffset(rectCaPheMay.TransformToVisual(scrollViewer).TransformBounds(new Rect(0, 0, 0, 0)).Top);
        }

        private void DaXay_Click(object sender, RoutedEventArgs e)
        {
            scrollViewer.ScrollToVerticalOffset(rectDaXay.TransformToVisual(scrollViewer).TransformBounds(new Rect(0, 0, 0, 0)).Top);
        }

        private void TraTraiCay_Click(object sender, RoutedEventArgs e)
        {
            scrollViewer.ScrollToVerticalOffset(rectTraTraiCay.TransformToVisual(scrollViewer).TransformBounds(new Rect(0, 0, 0, 0)).Top);
        }

        private void TraSuaMacchiato_Click(object sender, RoutedEventArgs e)
        {
            scrollViewer.ScrollToVerticalOffset(rectTraSuaMacchiato.TransformToVisual(scrollViewer).TransformBounds(new Rect(0, 0, 0, 0)).Top);
        }
    }
}
