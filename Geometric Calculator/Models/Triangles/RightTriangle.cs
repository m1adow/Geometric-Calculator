namespace Geometric_Calculator.Models.Triangles
{
    public class RightTriangle : Triangle
    {
        public RightTriangle(double firstSide = 0, double secondSide = 0, double thirdSide = 0, double firstHeight = 0, double secondHeight = 0, double thirdHeight = 0, byte firstAngle = 0, byte secondAngle = 0)
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

            GetThirdSideWithPythagoreanTheorem();
        }

        private void GetThirdSideWithPythagoreanTheorem()
        {
            if (this._firstSide != 0 && this._secondSide != 0 && this._thirdSide == 0) this._thirdSide = Math.Sqrt(Math.Pow(this._firstSide, 2) + Math.Pow(this._secondSide, 2));
            else if (this._firstSide != 0 && this._secondSide == 0 && this._thirdSide != 0) this._secondSide = Math.Sqrt(Math.Pow(this._thirdSide, 2) - Math.Pow(this._firstSide, 2));
            else if (this._firstSide == 0 && this._secondSide != 0 && this._thirdSide != 0) this._secondSide = Math.Sqrt(Math.Pow(this._thirdSide, 2) - Math.Pow(this._secondSide, 2));
        }
    }
}