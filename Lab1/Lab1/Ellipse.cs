namespace Lab1
{
    public class tEllipse : Shapes
    {
        private readonly double top;
        private readonly double left;

        private readonly tPoint center;

        public tEllipse(double top, double left, tPoint center, string title) : base(title)
        {
            this.top = top;
            this.left = left;
            this.center = center;
        }

        public double GetLeft()
        {
            return left;
        }

        public double GetTop()
        {
            return top;
        }

        public tPoint GetCenter()
        {
            return center;
        }

        public override void ShiftX(double value)
        {
            center.ShiftX(value);
        }

        public override void ShiftY(double value)
        {
            center.ShiftY(value);
        }
    }
}
