namespace Lab1
{
    public class tLine : Shapes
    {
        private readonly tPoint startPoint;
        private readonly tPoint endPoint;


        public tLine(tPoint startPoint, tPoint endPoint, string title) : base(title)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        public tPoint GetStartPoint()
        {
            return startPoint;
        }

        public tPoint GetEndPoint()
        {
            return endPoint;
        }

        public override void ShiftX(double value)
        {
            startPoint.ShiftX(value);
            endPoint.ShiftX(value);
        }

        public override void ShiftY(double value)
        {
            startPoint.ShiftY(value);
            endPoint.ShiftY(value);
        }
    }
}
