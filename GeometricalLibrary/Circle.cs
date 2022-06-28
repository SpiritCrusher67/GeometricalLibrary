namespace GeometricalLibrary
{
    public class Circle : Figure
    {
        public Circle(double radius) => 
            Radius = radius;
        public double Radius { get; set; }

        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
