using Geometric_Calculator.Models.Components;

namespace Geometric_Calculator.Models.Quadrangles.Trapezoids;

public class Trapezoid
{
    protected Side[] _sides;
    protected Angle[] _angles;
    protected Diagonal[] _diagonals;
    protected Height[] _heights;

    public Trapezoid(double smallWarp, double bigWarp, double firstSide, double secondSide, double firstAngle, double secondAngle, double thirdAngle, double fourthAngle, double firstDiagonal, double secondDiagonal, double firstHeight, double secondHeight, double thirdHeight, double fourthHeight)
    {
        _sides = new Side[4] { new Side(smallWarp), new Side(bigWarp), new Side(firstSide), new Side(secondSide) }; //initiate array with sides
        _angles = new Angle[4] { new Angle(0, firstAngle), new Angle(0, secondAngle), new Angle(0, thirdAngle), new Angle(0, fourthAngle) }; //initiate array with angles in degrees
        _diagonals = new Diagonal[2] { new Diagonal(firstDiagonal), new Diagonal(secondDiagonal) }; //initiate array with degress
        _heights = new Height[4] { new Height(firstHeight), new Height(secondHeight), new Height(thirdHeight), new Height(fourthHeight) }; //initiate array with heights
    }

    public double GetArea()
    {
        if (GetAreaWithMiddleLineFormula() > 0) return GetAreaWithMiddleLineFormula();

        throw new Exception("Area can't be less or equal to 0");
    }

    public double GetAreaWithMiddleLineFormula()
    {
        if (_heights.Any(h => h.Length != 0)) return GetMiddleLine() * _heights.FirstOrDefault(h => h.Length != 0).Length;
        return 0;
    }

    private double GetMiddleLine()
    {
        if (_sides[0].Length != 0 || _sides[1].Length != 0) return 0.5 * (_sides[0].Length + _sides[1].Length);
        return 0;
    }
}