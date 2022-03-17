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

            this._firstAngle = Angle.ConvertDegreesToRadians(60);
            this._secondAngle = this._firstAngle;
            this._thirdAngle = this._secondAngle;
        }
    }
}
