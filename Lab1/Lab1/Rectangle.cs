namespace Lab1
{
    public class tRectangle : Shapes
    {
        private readonly tLine l1;
        private readonly tLine l2;
        private readonly tLine l3;
        private readonly tLine l4;

        public tRectangle(tLine l1, tLine l2, tLine l3, tLine l4, string title) : base(title)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
            this.l4 = l4;
        }

        public tLine GetLine1()
        {
            return l1;
        }

        public tLine GetLine2()
        {
            return l2;
        }

        public tLine GetLine3()
        {
            return l3;
        }

        public tLine GetLine4()
        {
            return l4;
        }

        public override void ShiftX(double value)
        {
            l1.ShiftX(value);
            l2.ShiftX(value);
            l3.ShiftX(value);
            l4.ShiftX(value);
        }

        public override void ShiftY(double value)
        {
            l1.ShiftY(value);
            l2.ShiftY(value);
            l3.ShiftY(value);
            l4.ShiftY(value);
        }
    }
}
