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
using System.IO;

namespace isoprojekti
{
    /// <summary>
    /// Interaction logic for Drag_and_Drop.xaml
    /// </summary>
    public partial class Drag_and_Drop : Window
    {
        public Drag_and_Drop()
        {
            InitializeComponent();
        }

        private void textBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.All;
            }
        }

        private void textBox_PreviewDragEnter(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.All;
            e.Handled = true;
        }

        private void textBox_PreviewDragOver(object sender, DragEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_PreviewDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                StreamReader myReader = new StreamReader(files[0]);
                textBox.Text = myReader.ReadToEnd();
                myReader.Close();
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (Clipboard.ContainsFileDropList())
            {
                foreach (string teksti in Clipboard.GetFileDropList())
                {
                    StreamReader sr = new StreamReader(teksti);
                    textBox.Text = sr.ReadToEnd();
                }
            }
        }
    }
}
