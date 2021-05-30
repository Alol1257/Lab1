namespace Lab1
{
    public class tCircle : Shapes
    {
        private readonly double top;
        private readonly tPoint center;

        public tCircle(double top, tPoint center, string title) : base(title)
        {
            this.top = top;
            this.center = center;
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
