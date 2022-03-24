namespace Geometric_Calculator.Models.Quadrangles.Trapezoids;

public class TrueTrapezoid : Trapezoid
{
    public TrueTrapezoid(double smallWarp, double bigWarp, double side, double firstAngle, double secondAngle, double diagonal, double firstHeight, double secondHeight) : base(smallWarp, bigWarp, side, side, firstAngle, firstAngle, secondAngle, secondAngle, diagonal, diagonal, firstHeight, secondHeight, firstHeight, secondHeight)
    {

    }
}