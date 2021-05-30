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

namespace LW1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<tPoint> tPoints = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void DrawPoint(tPoint point)
        {
            Ellipse ellipse = new();

            ellipse.Height = 5;
            ellipse.Width = 5;

            ellipse.Stroke = Brushes.Red;
            ellipse.StrokeThickness = 2;

            ellipse.Margin = new Thickness(point.GetX() - 2, point.GetY() - 2, 0, 0);

            Canvas.Children.Add(ellipse);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new();

            for (int i = 0; i < 100; i++)
            {
                double x = rnd.Next(0, 500);
                double y = rnd.Next(0, 500);

                tPoint tPoint = new(x, y);

                tPoints.Add(tPoint);
            }

            foreach (tPoint point in tPoints)
            {
                //DrawPoint(point);
            }
        }
    }
}
