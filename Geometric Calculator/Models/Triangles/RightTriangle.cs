using Geometric_Calculator.Models.Components;

namespace Geometric_Calculator.Models.Triangles;

public class RightTriangle : Triangle
{
    public RightTriangle(double firstSide, double secondSide, double thirdSide, double firstHeight, double secondHeight, double thirdHeight, byte firstAngle, byte secondAngle) : base(firstSide, secondSide, thirdSide, firstHeight, secondHeight, thirdHeight, firstAngle, secondAngle, 90)
    {
        this._sides = new Side[3] { new Side(firstSide), new Side(secondSide), new Side(thirdSide) }; //initiate array with sides
        this._angles = new Angle[3] { new Angle(0, firstAngle), new Angle(0, secondAngle), new Angle(0, 90) }; //initiate array with angles in degrees which last one equal 90
        this._heights = new Height[3] { new Height(firstHeight), new Height(secondHeight), new Height(thirdHeight) }; //initiate array with heights

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