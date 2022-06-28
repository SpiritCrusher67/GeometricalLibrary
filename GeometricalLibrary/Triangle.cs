namespace GeometricalLibrary
{
    public class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC) =>
            (SideA, SideB, SideC) = IsExist(sideA, sideB, sideC) 
            ? (sideA, sideB, sideC) 
            : throw new ArgumentException("Triangle with given sides cannot exist");

        private bool IsExist(double sideA, double sideB, double sideC) => 
            (sideA + sideB) >= sideC && 
            (sideA + sideC) >= sideB && 
            (sideB + sideC) >= sideA;
        
        public override double CalculateArea()
        {
            var perimeter = SideA + SideB + SideC;
            var halfPerimeter = perimeter / 2;
            return Math.Sqrt(
                halfPerimeter * 
                (halfPerimeter - SideA) * 
                (halfPerimeter - SideB) *
                (halfPerimeter - SideC));
        }

        public bool IsRectangular()
        {
            var sideASqr = SideA * SideA;
            var sideBSqr = SideB * SideB;
            var sideCSqr = SideC * SideC;

            return (sideASqr + sideBSqr) == sideCSqr || 
                (sideASqr + sideCSqr) == sideBSqr ||
                (sideBSqr + sideCSqr) == sideASqr;
        }
    }
}
