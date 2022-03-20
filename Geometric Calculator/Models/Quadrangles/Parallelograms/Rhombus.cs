namespace Geometric_Calculator.Models.Quadrangles.Parallelograms;


public class Rhombus : Parallelogram
{
    public Rhombus(double side, double firstDiagonal, double secondDiagonal, double firstAndThirdHeight, double secondAndFourthHeight, double firstAndThirdAngle, double secondAndFourthAngle) : base(side, side, firstDiagonal, secondDiagonal, firstAndThirdHeight, secondAndFourthHeight, firstAndThirdAngle, secondAndFourthAngle, 90)
    {

    }
}
