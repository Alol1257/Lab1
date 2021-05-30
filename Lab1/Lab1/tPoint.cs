namespace Lab1
{
    public class tPoint : Shapes
    {
        private double x;
        private double y;

        public tPoint(double x, double y, string title) : base(title)
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

        public override void ShiftX(double value)
        {
            x += value;
        }

        public override void ShiftY(double value)
        {
            y += value;
        }
    }
}
