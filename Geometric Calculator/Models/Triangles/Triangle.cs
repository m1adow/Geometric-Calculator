using Geometric_Calculator.Models.Components;

namespace Geometric_Calculator.Models.Triangles;

public class Triangle
{
    protected Side[] _sides;
    protected Angle[] _angles;
    protected Height[] _heights;

    public Triangle(double firstSide = 0, double secondSide = 0, double thirdSide = 0, double firstHeight = 0, double secondHeight = 0, double thirdHeight = 0, byte firstAngle = 0, byte secondAngle = 0, byte thirdAngle = 0)
    {
        _sides = new Side[3] { new Side(firstSide), new Side(secondSide), new Side(thirdSide) }; //initiate array with sides
        _angles = new Angle[3] { new Angle(0, firstAngle), new Angle(0, secondAngle), new Angle(0, thirdAngle) }; //initiate array with angles in degrees
        _heights = new Height[3] { new Height(firstHeight), new Height(secondHeight), new Height(thirdHeight) }; //initiate array with heights
    }

    public double GetArea()
    {
        if (GetAreaWithSinFormula() != 0) return GetAreaWithSinFormula();
        else if (GetAreaWithGeronFormula() != 0) return GetAreaWithGeronFormula();
        else if (GetAreaWithHeightFormula() != 0) return GetAreaWithHeightFormula();
        return 0;
    }

    private double GetAreaWithGeronFormula()
    {
        //S = sqrt(p * (p - a) * (p - b) * (p - c), where p - half of P(perimeter) 
        //if all sides length not equal 0 - solve
        if (_sides.All(s => s.Length != 0))
        {
            double halfOfPerimeter = _sides.Sum(s => s.Length) / 2;

            return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - _sides[0].Length) * (halfOfPerimeter - _sides[1].Length) * (halfOfPerimeter - _sides[2].Length));
        }

        return 0;
    }

    private double GetAreaWithHeightFormula()
    {
        //S = 0.5 * a * h(a)
        if (_sides[0].Length != 0 && _heights[0].Length != 0) return 0.5 * _heights[0].Length * _sides[0].Length;
        else if (_sides[1].Length != 0 && _heights[1].Length != 0) return 0.5 * _heights[1].Length * _sides[1].Length;
        else if (_sides[2].Length != 0 && _heights[2].Length != 0) return 0.5 * _heights[2].Length * _sides[2].Length;
        return 0;
    }

    private double GetAreaWithSinFormula()
    {
        //S = 0.5 * a * b * sin(<(A;B))
        if (_sides[0].Length != 0 && _sides[1].Length != 0 && _angles[2].Radians != 0) return 0.5 * _sides[0].Length * _sides[1].Length * Math.Sin(_angles[2].Radians);
        else if (_sides[1].Length != 0 && _sides[2].Length != 0 && _angles[0].Radians != 0) return 0.5 * _sides[1].Length * _sides[2].Length * Math.Sin(_angles[0].Radians);
        else if (_sides[0].Length != 0 && _sides[2].Length != 0 && _angles[1].Radians != 0) return 0.5 * _sides[1].Length * _sides[2].Length * Math.Sin(_angles[1].Radians);
        return 0;
    }
}