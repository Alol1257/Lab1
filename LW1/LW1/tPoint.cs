using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Lab1
{
    public class tPoint
    {
        private double x;
        private double y;

        public tPoint()
        {
            //Конструктор по умолчанию;
        }

        public tPoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }

        public void RandomShift()
        {
            Random value = new();

            x += value.Next(0, 500);
            y += value.Next(0, 500);
        }

        public void ShiftX(double value)
        {
            x += value;
        }

        public void ShiftY(double value)
        {
            y += value;
        }
    }
}
