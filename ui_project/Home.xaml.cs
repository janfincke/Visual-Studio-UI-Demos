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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace isoprojekti
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            //drag/drop
            Drag_and_Drop drag = new Drag_and_Drop();
            drag.Show();

        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            //webbisivun luku
            HTTP_Request http = new HTTP_Request();
            http.Show();
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            //ink canvas
            Ink_Canvas ink = new Ink_Canvas();
            ink.Show();
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            //organisaatiokaavioeditori
            Organisation org = new Organisation();
            org.Show();

        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            //listview
            ListView listview = new ListView();
            listview.Show();
        }
    }
}
