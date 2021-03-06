using Geometric_Calculator.Models.Components;

namespace Geometric_Calculator.Models.Triangles;

public class Triangle
{
    protected Side[] _sides;
    protected Angle[] _angles;
    protected Height[] _heights;

    public Triangle(double firstSide, double secondSide, double thirdSide, double firstHeight, double secondHeight, double thirdHeight, double firstAngle, double secondAngle, double thirdAngle)
    {
        _sides = new Side[3] { new Side(firstSide), new Side(secondSide), new Side(thirdSide) }; //initiate array with sides
        _angles = new Angle[3] { new Angle(0, firstAngle), new Angle(0, secondAngle), new Angle(0, thirdAngle) }; //initiate array with angles in degrees
        _heights = new Height[3] { new Height(firstHeight), new Height(secondHeight), new Height(thirdHeight) }; //initiate array with heights

        FindAngles(); //find all angles if it's possible
    }

    public double GetArea()
    {
        if (GetAreaWithSinFormula() > 0) return GetAreaWithSinFormula();
        else if (GetAreaWithGeronFormula() > 0) return GetAreaWithGeronFormula();
        else if (GetAreaWithHeightFormula() > 0) return GetAreaWithHeightFormula();

        throw new Exception("Area can't be less or equal to 0");
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

    private void FindAngles()
    {
        double thirdAngle = 180; //declare variable for result with start value of sum of angles in triangle

        //examination for containing 2 angles
        if (_angles.Where(a => a.Radians != 0).Count() == 2)
        {
            var angles = _angles.Where(a => a.Radians != 0); //take all filled angles

            foreach (var angle in angles) thirdAngle -= angle.Degrees; //subtract degree values from angles

            Angle? desiredAngle = _angles.FirstOrDefault(a => a.Radians == 0); //take empty angle
            desiredAngle.Degrees = thirdAngle;
            desiredAngle.ConvertDegreesToRadians();
        }
    }
}