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
using System.Net;
using System.Web;
using System.IO;

namespace isoprojekti
{
    /// <summary>
    /// Interaction logic for HTTP_Request.xaml
    /// </summary>
    public partial class HTTP_Request : Window
    {
        public HTTP_Request()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            WebClient web = new WebClient();
            System.IO.Stream stream = web.OpenRead(textBox.Text);
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            {
                String text = reader.ReadToEnd();
                textBlock.Text = text;
            }
            StreamWriter writer = File.CreateText("c:\\temp\\httprequest.txt");
            writer.WriteLine(textBlock.Text + "\n");
            writer.Close();
        }
    }
}
