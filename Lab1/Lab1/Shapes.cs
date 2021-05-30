namespace Lab1
{
    public abstract class Shapes
    {
        private readonly string title;

        public Shapes(string title)
        {
            this.title = title;
        }

        public string GetTitle()
        {
            return title;
        }

        public abstract void ShiftX(double value);

        public abstract void ShiftY(double value);
    }
}
