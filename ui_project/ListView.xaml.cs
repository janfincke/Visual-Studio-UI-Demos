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

namespace isoprojekti
{
    /// <summary>
    /// Interaction logic for ListView.xaml
    /// </summary>
    public partial class ListView : Window
    {
        public ListView()
        {
            InitializeComponent();
            var gridView = new GridView();
            this.listView.View = gridView;
            gridView.Columns.Add(new GridViewColumn
            {
                Header = "Name",
                DisplayMemberBinding = new Binding("Name")
            });
            gridView.Columns.Add(new GridViewColumn
            {
                Header = "Birthyear",
                DisplayMemberBinding = new Binding("Birthyear")
            });

            this.listView.Items.Add(new MyItem { Birthyear = 1970, Name = "Jan" });
            this.listView.Items.Add(new MyItem { Birthyear = 1890, Name = "Santtu" });
            this.listView.Items.Add(new MyItem { Birthyear = 1710, Name = "Ossi" });
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int text1 = Convert.ToInt16(textBox1.Text);
            listView.Items.Add(new MyItem { Name = textBox.Text, Birthyear = text1 });
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listView.Items.Remove(listView.SelectedItem);
        }
    }
}
