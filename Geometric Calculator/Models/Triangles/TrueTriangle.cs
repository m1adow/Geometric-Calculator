using Geometric_Calculator.Models.Components;

namespace Geometric_Calculator.Models.Triangles;

public class TrueTriangle : Triangle
{
    public TrueTriangle(double side, double firstHeight, double secondHeight, double thirdHeight) : base(side, side, side, firstHeight, secondHeight, thirdHeight, 60, 60, 60)
    {
        
    }
}