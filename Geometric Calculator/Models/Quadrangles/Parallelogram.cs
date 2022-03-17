namespace Geometric_Calculator.Models.Quadrangles
{
    public class Parallelogram
    {
        protected double _firstSide;
        protected double _secondSide;
        protected double _thirdSide;
        protected double _fourthSide;

        protected double _firstDiagonal;
        protected double _secondDiagonal;

        protected double _firstHeight;
        protected double _secondHeight;
        protected double _thirdHeight;
        protected double _fourthHeight;

        protected double _firstAngle;
        protected double _secondAngle;
        protected double _thirdAngle;
        protected double _fourthAngle;

        public Parallelogram(double firstAndThirdSide = 0, double secondAndFourthSide = 0, double firstDiagonal = 0, double secondDiagonal = 0, double firstAndThirdHeight = 0, double secondAndFourthHeight = 0, double firstAndThirdAngle = 0, double secondAndFourthAngle = 0)
        {
            _firstSide = firstAndThirdSide;
            _thirdSide = firstAndThirdSide;
            _secondSide = secondAndFourthSide;
            _fourthSide = secondAndFourthSide;

            _firstDiagonal = firstDiagonal;
            _secondDiagonal = secondDiagonal;

            _firstHeight = firstAndThirdHeight;
            _thirdHeight = firstAndThirdHeight;
            _secondHeight = secondAndFourthHeight;
            _fourthHeight = secondAndFourthHeight;

            _firstAngle = Angle.ConvertDegreesToRadians(firstAndThirdAngle);
            _thirdAngle = Angle.ConvertDegreesToRadians(firstAndThirdAngle);
            _secondAngle = Angle.ConvertDegreesToRadians(secondAndFourthAngle);
            _fourthAngle = Angle.ConvertDegreesToRadians(secondAndFourthAngle);
        }

        public double GetArea()
        {
            if (GetAreaWithHeightFormula() != 0) return GetAreaWithHeightFormula();
            else if (GetAreaWithSinFormula() != 0) return GetAreaWithSinFormula();
            return 0;
        }

        private double GetAreaWithHeightFormula()
        {
            if (_firstSide != 0 && _firstHeight != 0) return _firstSide * _firstHeight;
            else if (_secondSide != 0 && _secondHeight != 0) return _secondSide * _secondHeight;
            else if (_thirdSide != 0 && _thirdHeight != 0) return _thirdSide * _thirdHeight;
            else if (_fourthSide != 0 && _fourthHeight != 0) return _fourthSide * _fourthHeight;
            return 0;
        }

        private double GetAreaWithSinFormula()
        {
            if (_firstSide != 0 && _secondSide != 0)
            {
                return _firstAngle != 0 ? _firstSide * _secondSide * Math.Sin(_firstAngle) : //if first angle doesnt equal 0 - solve
                    _thirdAngle != 0 ? _firstSide * _secondSide * Math.Sin(_thirdAngle) : //if third angle doesnt equal 0 - solve
                    _secondAngle != 0 ? _firstSide * _secondSide * Math.Sin(_secondAngle) : //if second angle doesnt equal 0 - solve
                    _thirdAngle != 0 ? _firstSide * _secondSide * Math.Sin(_fourthAngle) :  //if fourth angle doesnt equal 0 - solve
                    0; //if all angles are 0 - return 0
            }

            return 0;
        }
    }
}