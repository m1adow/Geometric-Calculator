namespace Geometric_Calculator.Models.Triangles
{
    public class Triangle
    {
        protected double _firstSide;
        protected double _secondSide;
        protected double _thirdSide;

        protected double _firstHeight;
        protected double _secondHeight;
        protected double _thirdHeight;

        protected double _firstAngle;
        protected double _secondAngle;
        protected double _thirdAngle;

        public Triangle(double firstSide = 0, double secondSide = 0, double thirdSide = 0, double firstHeight = 0, double secondHeight = 0, double thirdHeight = 0, byte firstAngle = 0, byte secondAngle = 0, byte thirdAngle = 0)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;

            _firstHeight = firstHeight;
            _secondHeight = secondHeight;
            _thirdHeight = thirdHeight;

            _firstAngle = firstAngle * Math.PI / 180;
            _secondAngle = secondAngle * Math.PI / 180;
            _thirdAngle = thirdAngle * Math.PI / 180;
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
            if (_firstSide != 0 && _secondSide != 0 && _thirdSide != 0)
            {
                double halfOfPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;

                return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - _firstSide) * (halfOfPerimeter - _secondSide) * (halfOfPerimeter - _thirdSide));
            }
            return 0;
        }

        private double GetAreaWithHeightFormula()
        {
            if (_firstSide != 0 && _firstHeight != 0) return 0.5 * _firstHeight * _firstSide;
            else if (_secondSide != 0 && _secondHeight != 0) return 0.5 * _secondHeight * _secondSide;
            else if (_thirdSide != 0 && _thirdHeight != 0) return 0.5 * _thirdHeight * _thirdSide;
            return 0;
        }

        private double GetAreaWithSinFormula()
        {
            if (_firstSide != 0 && _secondSide != 0 && _thirdAngle != 0) return 0.5 * _firstSide * _secondSide * Math.Sin(_thirdAngle);
            else if (_secondSide != 0 && _thirdSide != 0 && _firstAngle != 0) return 0.5 * _secondSide * _thirdSide * Math.Sin(_firstAngle);
            else if (_firstSide != 0 && _thirdSide != 0 && _secondAngle != 0) return 0.5 * _secondSide * _thirdSide * Math.Sin(_secondAngle);
            return 0;
        }      
    }
}