namespace csharp.training.congruent.classes
{

    public class Point2D
    {

        private double _x;
        private double _y;
        public override string ToString()
        {
            return $"({_x}, {_y})";
        }

        public Point2D(int x, int y)
        {
            _x = x; _y = y;
        }
        public Point2D()
        {
            _x = 0.0d; _y = 0.0d;
        }
        public static void ModifyPointRef(ref Point2D point)
        {
            point.X = 30;
            point.Y = 40;
            Console.WriteLine($"Inside Modify by Reference: {point}");
        }

        public static void ModifyPointValue(Point2D point)
        {
            point.X = 10;
            point.Y = 20;
            Console.WriteLine($"Inside Modify by Value: {point}");
        }
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }
       
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}