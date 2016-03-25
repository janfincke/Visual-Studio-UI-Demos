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
    /// Interaction logic for Organisation.xaml
    /// </summary>
    public partial class Organisation : Window
    {
        public Organisation()
        {
            InitializeComponent();
        }
        int bosses = 0; // ylin rivi
        int managers = 0; // seuraava
        int workers = 0; //alin
        int rCount = 0;
        int kCount = 0;
        int cCount = 0;
        int x = 0;
        int p = 0;
        int q = 0;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Rectangle k = new Rectangle();
            k.Height = 50;
            k.Width = 100;
            k.Stroke = Brushes.Black; // reunaviiva
            k.Fill = Brushes.White; // täyttöväri
            Canvas.SetLeft(k, bosses * 110); // paikka
            Canvas.SetTop(k, 10);

            //LINE
            Line redLine = new Line();
            redLine.X1 = 50 + x;
            redLine.Y1 = 60;
            redLine.X2 = 50 + x;
            redLine.Y2 = 100;

            SolidColorBrush redBrush = new SolidColorBrush();
            redBrush.Color = Colors.Red;

            redLine.StrokeThickness = 4;
            redLine.Stroke = redBrush;

            TextBlock textblock = new TextBlock();
            textblock.Text = "Boss";
            textblock.Margin = new Thickness(35 + x, 20, 50, 50);


            //DRAW   

            if (kCount < 3)
            {
                omaCanvas.Children.Add(k);
                omaCanvas.Children.Add(textblock);
                if (kCount < rCount)
                {
                    omaCanvas.Children.Add(redLine);
                };
                kCount = kCount + 1;
            }
            bosses++;


            x = x + 110;
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            // laatikko
            Rectangle r = new Rectangle();
            r.Height = 50;
            r.Width = 100;
            r.Stroke = Brushes.Black;
            r.Fill = Brushes.White;
            Canvas.SetLeft(r, managers * 110); // uusi laatikko edellisen oikealle puolelle
            Canvas.SetTop(r, 100);

            //LINE 1
            Line redLine = new Line();
            redLine.X1 = 50 + p;
            redLine.Y1 = 150;
            redLine.X2 = 50 + p;
            redLine.Y2 = 200;

            SolidColorBrush redBrush = new SolidColorBrush();
            redBrush.Color = Colors.Red;

            redLine.StrokeThickness = 4;
            redLine.Stroke = redBrush;

            //LINE 2
            Line redLine2 = new Line();
            redLine2.X1 = 50 + p;
            redLine2.Y1 = 60;
            redLine2.X2 = 50 + p;
            redLine2.Y2 = 100;

            SolidColorBrush redBrush2 = new SolidColorBrush();
            redBrush2.Color = Colors.Red;

            redLine2.StrokeThickness = 4;
            redLine2.Stroke = redBrush2;

            TextBlock textblock = new TextBlock();
            textblock.Text = "Manager";
            textblock.Margin = new Thickness(25 + p, 110, 50, 50);

            if (rCount < 3)
            {
                omaCanvas.Children.Add(r);
                omaCanvas.Children.Add(textblock);
                if (rCount < kCount)
                {
                    omaCanvas.Children.Add(redLine2);
                }
                if (rCount < cCount)
                {
                    omaCanvas.Children.Add(redLine);
                }

                rCount = rCount + 1;
            }
            managers++;

            p = p + 110;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // laatikko
            Rectangle c = new Rectangle();
            c.Height = 50;
            c.Width = 100;
            c.Stroke = Brushes.Black;
            c.Fill = Brushes.White;
            Canvas.SetLeft(c, workers * 110); // uusi laatikko edellisen oikealle puolelle
            Canvas.SetTop(c, 200);

            //LINE 1
            Line redLine = new Line();
            redLine.X1 = 50 + q;
            redLine.Y1 = 150;
            redLine.X2 = 50 + q;
            redLine.Y2 = 200;

            SolidColorBrush redBrush = new SolidColorBrush();
            redBrush.Color = Colors.Red;

            redLine.StrokeThickness = 4;
            redLine.Stroke = redBrush;

            TextBlock textblock = new TextBlock();
            textblock.Text = "Worker";
            textblock.Margin = new Thickness(30 + q, 210, 50, 50);


            if (cCount < 3)
            {
                omaCanvas.Children.Add(c);
                omaCanvas.Children.Add(textblock);

                if (cCount < rCount)
                {
                    omaCanvas.Children.Add(redLine);
                }

                cCount = cCount + 1;
            }
            q = q + 110;
            workers++;

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            omaCanvas.Children.Clear();
            x = 0;
            p = 0;
            q = 0;
            rCount = 0;
            cCount = 0;
            kCount = 0;
            bosses = 0;
            managers = 0;
            workers = 0;
        }

        
    }
    
}

    
 

