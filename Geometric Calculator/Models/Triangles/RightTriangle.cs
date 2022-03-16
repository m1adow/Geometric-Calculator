namespace Geometric_Calculator.Models.Triangles
{
    public class RightTriangle : Triangle
    {
        public RightTriangle(double firstSide, double secondSide, double thirdSide, double firstHeight, double secondHeight, double thirdHeight, byte firstAngle, byte secondAngle)
        {
            this._firstSide = firstSide;
            this._secondSide = secondSide;
            this._thirdSide = thirdSide;

            this._firstHeight = firstHeight;
            this._secondHeight = secondHeight;
            this._thirdHeight = thirdHeight;

            this._firstAngle = firstAngle * Math.PI / 180;
            this._secondAngle = secondAngle * Math.PI / 180;
            this._thirdAngle = 90 * Math.PI / 180;
        }
    }
}