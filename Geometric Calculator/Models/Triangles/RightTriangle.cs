using Geometric_Calculator.Models.Components;

namespace Geometric_Calculator.Models.Triangles;

public class RightTriangle : Triangle
{
    public RightTriangle(double firstSide, double secondSide, double thirdSide, double firstHeight, double secondHeight, double thirdHeight, byte firstAngle, byte secondAngle) : base(firstSide, secondSide, thirdSide, firstHeight, secondHeight, thirdHeight, firstAngle, secondAngle, 90)
    {
        GetThirdSideWithPythagoreanTheorem(); //if two of free sides known find next one
    }

    private void GetThirdSideWithPythagoreanTheorem()
    {
        //c^2 = a^2 + b^2
        if (this._sides[0].Length != 0 && this._sides[1].Length != 0 && this._sides[2].Length == 0) this._sides[2].Length = Math.Sqrt(Math.Pow(this._sides[0].Length, 2) + Math.Pow(this._sides[1].Length, 2));
        else if (this._sides[0].Length != 0 && this._sides[1].Length == 0 && this._sides[2].Length != 0) this._sides[1].Length = Math.Sqrt(Math.Pow(this._sides[2].Length, 2) - Math.Pow(this._sides[0].Length, 2));
        else if (this._sides[0].Length == 0 && this._sides[1].Length != 0 && this._sides[2].Length != 0) this._sides[0].Length = Math.Sqrt(Math.Pow(this._sides[2].Length, 2) - Math.Pow(this._sides[1].Length, 2));
    }
}