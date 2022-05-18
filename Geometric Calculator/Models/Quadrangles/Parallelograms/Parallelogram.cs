using Geometric_Calculator.Models.Components;

namespace Geometric_Calculator.Models.Quadrangles.Parallelograms;

public class Parallelogram
{
    protected Side[] _sides;
    protected Angle[] _angles;
    protected Diagonal[] _diagonals;
    protected Height[] _heights;

    public Parallelogram(double firstAndThirdSide, double secondAndFourthSide, double firstDiagonal, double secondDiagonal, double firstAndThirdHeight, double secondAndFourthHeight, double firstAndThirdAngle, double secondAndFourthAngle, double angleBetweenDiagonals)
    {
        _sides = new Side[2] { new Side(firstAndThirdSide), new Side(secondAndFourthSide) }; //initiate array with sides
        _angles = new Angle[3] { new Angle(0, firstAndThirdAngle), new Angle(0, secondAndFourthAngle), new Angle(0, angleBetweenDiagonals) }; //initiate array with angles in degrees
        _diagonals = new Diagonal[2] { new Diagonal(firstDiagonal), new Diagonal(secondDiagonal) }; //initiate array with degress
        _heights = new Height[2] { new Height(firstAndThirdHeight), new Height(secondAndFourthHeight) }; //initiate array with heights
    }

    public double GetArea()
    {
        if (GetAreaWithSinFormula() > 0) return GetAreaWithSinFormula();
        else if (GetAreaWithDiagonalFormula() > 0) return GetAreaWithDiagonalFormula();
        else if (GetAreaWithHeightFormula() > 0) return GetAreaWithHeightFormula();

        throw new Exception("Area can't be less or equal to 0");
    }

    private double GetAreaWithHeightFormula()
    {
        //S = a * h(a)
        if (_sides[0].Length != 0 && _heights[0].Length != 0) return _sides[0].Length * _heights[0].Length;
        else if (_sides[1].Length != 0 && _heights[1].Length != 0) return _sides[1].Length * _heights[1].Length;
        return 0;
    }

    private double GetAreaWithSinFormula()
    {
        //S = a * b * sin(c)
        //if sides not equal 0 and any of angles not equal 0 - solve
        if (_sides.All(s => s.Length != 0))
            if (_angles.Any(a => a.Radians != 0))
                return _sides[0].Length * _sides[1].Length * Math.Sin(_angles.FirstOrDefault(a => a.Radians != 0).Radians);

        return 0;
    }

    private double GetAreaWithDiagonalFormula()
    {
        //S = 0.5 * d1 * d2 * sin(<(d1; d2))
        if (_angles[2].Radians != 0 && _diagonals.All(d => d.Length != 0)) return 0.5 * _diagonals[0].Length * _diagonals[1].Length * Math.Sin(_angles[2].Radians);
        return 0;
    }
}
