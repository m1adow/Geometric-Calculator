namespace Geometric_Calculator.Models.Quadrangles;

public class Rectangle : Parallelogram
{
    public Rectangle(double firstAndThirdSide, double secondAndFourthSide, double diagonal, double angleBetweenDiagonals) : base(firstAndThirdSide, secondAndFourthSide, diagonal, diagonal, 0, 0, 90, 90, angleBetweenDiagonals)
    {

    }
}