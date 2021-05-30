using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private string hex;
        //private int numHex = 0;
        //private readonly string hexValue;

        //private readonly List<string> colors = new();
        private readonly List<Shapes> shapes = new();
        private readonly List<Shapes> searchRes = new();

        public MainWindow()
        {
            InitializeComponent();

            //for (int i = 0; i < 100; i++)
            //{
            //    Random rnd = new();

            //    int intValue = rnd.Next(0, 16777215);

            //    hexValue = intValue.ToString("X6");

            //    colors.Add("#" + hexValue);
            //}

            //hex = colors[0];
        }

        //private void ColorRandomize()
        //{
        //    hex = colors[numHex];

        //    if (numHex > 98) { numHex = 0; }
        //    else { numHex++; }
        //}

        private tPoint GetPoint()
        {
            Random rnd = new();

            double x = rnd.Next(200, 400);
            double y = rnd.Next(100, 300);

            string title = shapeTitle.Text;

            tPoint P = new(x, y, title);

            return P;
        }

        private tLine GetLine()
        {
            tPoint startPoint = GetPoint();
            tPoint endPoint = GetPoint();

            string title = shapeTitle.Text;

            tLine line = new(startPoint, endPoint, title);

            return line;
        }

        private tTriangle GetTriangle()
        {
            tLine l1 = GetLine();
            tLine l2 = new(l1.GetEndPoint(), GetLine().GetEndPoint(), "");
            tLine l3 = new(l2.GetEndPoint(), l1.GetStartPoint(), "");

            string title = shapeTitle.Text;

            tTriangle triangle = new(l1, l2, l3, title);

            return triangle;
        }

        private tRectangle GetRectangle()
        {
            tPoint p1 = GetPoint();
            tPoint p4 = GetPoint();
            tPoint p2 = new(p1.GetX(), p4.GetY(), "");
            tPoint p3 = new(p4.GetX(), p1.GetY(), "");

            tLine l1 = new(p1, p2, "");
            tLine l2 = new(p1, p3, "");
            tLine l3 = new(p2, p4, "");
            tLine l4 = new(p3, p4, "");

            string title = shapeTitle.Text;

            tRectangle rectangle = new(l1, l2, l3, l4, title);

            return rectangle;
        }

        private tEllipse GetEllipse()
        {
            tPoint center = GetPoint();

            Random rnd = new();

            double height = rnd.Next(30, 60);
            double width = rnd.Next(30, 60);

            string title = shapeTitle.Text;

            tEllipse ellipse = new(height, width, center, title);

            return ellipse;
        }

        private tCircle GetCircle()
        {
            tPoint center = GetPoint();

            Random rnd = new();

            double height = rnd.Next(30, 60);

            string title = shapeTitle.Text;

            tCircle circle = new(height, center, title);

            return circle;
        }

        private void DrawLine(tLine line)
        {
            Line l = new()
            {
                Stroke = Brushes.Red,

                X1 = line.GetStartPoint().GetX(),
                Y1 = line.GetStartPoint().GetY(),

                X2 = line.GetEndPoint().GetX(),
                Y2 = line.GetEndPoint().GetY()
            };

            Canvas.Children.Add(l);
        }

        private void DrawTriangle(tTriangle triangle)
        {
            tLine l1 = triangle.GetLine1();
            tLine l2 = triangle.GetLine2();
            tLine l3 = triangle.GetLine3();

            DrawLine(l1);
            DrawLine(l2);
            DrawLine(l3);
        }

        private void DrawRectangle(tRectangle rectangle)
        {
            tLine l1 = rectangle.GetLine1();
            tLine l2 = rectangle.GetLine2();
            tLine l3 = rectangle.GetLine3();
            tLine l4 = rectangle.GetLine4();

            DrawLine(l1);
            DrawLine(l2);
            DrawLine(l3);
            DrawLine(l4);
        }

        private void DrawEllipse(tEllipse ellipse)
        {
            Ellipse e = new();

            e.Height = ellipse.GetTop();
            e.Width = ellipse.GetLeft();

            e.Stroke = Brushes.Red;
            e.StrokeThickness = 2;

            e.Margin = new Thickness(ellipse.GetCenter().GetX() - 2, ellipse.GetCenter().GetY() - 2, 0, 0);

            Canvas.Children.Add(e);
        }

        private void DrawCircle(tCircle circle)
        {
            Ellipse e = new();

            e.Height = circle.GetTop();
            e.Width = e.Height;

            e.Stroke = Brushes.Red;
            e.StrokeThickness = 2;

            e.Margin = new Thickness(circle.GetCenter().GetX() - 2, circle.GetCenter().GetY() - 2, 0, 0);

            Canvas.Children.Add(e);
        }

        private void DrawShapes(List<Shapes> shapes)
        {
            Canvas.Children.Clear();

            foreach (var shape in shapes)
            {
                if (shape.GetType() == typeof(tLine))
                {
                    tLine line = (tLine)shape;
                    DrawLine(line);
                }

                else if (shape.GetType() == typeof(tEllipse))
                {
                    tEllipse ellipse = (tEllipse)shape;
                    DrawEllipse(ellipse);
                }

                else if (shape.GetType() == typeof(tTriangle))
                {
                    tTriangle triangle = (tTriangle)shape;
                    DrawTriangle(triangle);
                }

                else if (shape.GetType() == typeof(tRectangle))
                {
                    tRectangle rectangle = (tRectangle)shape;
                    DrawRectangle(rectangle);
                }

                else if (shape.GetType() == typeof(tCircle))
                {
                    tCircle circle = (tCircle)shape;
                    DrawCircle(circle);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (ShapesType.SelectedIndex) 
            {
                case 0:
                    tPoint point = GetPoint();
                    shapes.Add(point);
                    break;
                case 1:
                    tLine line = GetLine();
                    shapes.Add(line);
                    break;
                case 2:
                    tEllipse ellipse = GetEllipse();
                    shapes.Add(ellipse);
                    break;
                case 3:
                    tTriangle triangle = GetTriangle();
                    shapes.Add(triangle);
                    break;
                case 4:
                    tRectangle rectangle = GetRectangle();
                    shapes.Add(rectangle);
                    break;
                case 5:
                    tCircle circle = GetCircle();
                    shapes.Add(circle);
                    break;
                default:
                    MessageBox.Show("Выберите фигуру!");
                    break;
            }

            DrawShapes(shapes);

            shapeTitle.Clear();
        }

        private void RndShift_Click(object sender, RoutedEventArgs e)
        {
            foreach(var shape in shapes)
            {
                Random rnd = new();

                shape.ShiftX(rnd.Next(-10, 10));
                shape.ShiftY(rnd.Next(-10, 10));
            }

            DrawShapes(shapes);
        }

        private void searchResult_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Canvas.Focus();
        }

        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            Canvas.Children.Clear();

            foreach(var shape in searchRes)
            {
                if(shapes.IndexOf(shape) == searchResult.SelectedIndex)

                switch (e.Key)
                {
                    case Key.W:
                        shape.ShiftY(-10);
                        break;
                    case Key.S:
                        shape.ShiftY(10);
                        break;
                    case Key.A:
                        shape.ShiftX(-10);
                        break;
                    case Key.D:
                        shape.ShiftX(10);
                        break;
                    default:
                        DrawShapes(shapes);
                        break;
                }

                DrawShapes(shapes);
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Canvas.Children.Clear();
            shapes.Clear();
            searchRes.Clear();
            searchResult.Items.Clear();
        }

        private void PrintBtn_Click(object sender, RoutedEventArgs e)
        {
            searchResult.Items.Clear();
            searchRes.Clear();

            foreach (var shape in shapes)
            {
                searchResult.Items.Add(shape.GetTitle());
                searchRes.Add(shape);
            }
        }
    }
}
