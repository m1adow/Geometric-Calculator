namespace Geometric_Calculator.Models.Triangles
{
    public class TrueTriangle : Triangle
    {
        public TrueTriangle(double side = 0, double firstHeight = 0, double secondHeight = 0, double thirdHeight = 0)
        {
            this._firstSide = side;
            this._secondSide = side;
            this._thirdSide = side;

            this._firstHeight = firstHeight;
            this._secondHeight = secondHeight;
            this._thirdHeight = thirdHeight;

            this._firstAngle = 60 * Math.PI / 180;
            this._secondAngle = 60 * Math.PI / 180;
            this._thirdAngle = 60 * Math.PI / 180;
        }
    }
}
