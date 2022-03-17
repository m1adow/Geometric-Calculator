using Geometric_Calculator.Models.Components;

namespace Geometric_Calculator.Models.Triangles;

public class TrueTriangle : Triangle
{
    public TrueTriangle(double side = 0, double firstHeight = 0, double secondHeight = 0, double thirdHeight = 0)
    {
        this._sides = new Side[3] { new Side(side), new Side(side), new Side(side) }; //initiate array with equal sides
        this._angles = new Angle[3] { new Angle(0, 60), new Angle(0, 60), new Angle(0, 60) }; //initiate array with angles in degrees which equal 60
        this._heights = new Height[3] { new Height(firstHeight), new Height(secondHeight), new Height(thirdHeight) }; //initiate array with heights
    }
}