using Geometric_Calculator.Models.Components;

namespace Geometric_Calculator.Models.Quadrangles
{
    public class Parallelogram
    {
        protected Side[] _sides;
        protected Angle[] _angles;
        protected Diagonal[] _diagonals;
        protected Height[] _heights;

        public Parallelogram(double firstAndThirdSide = 0, double secondAndFourthSide = 0, double firstDiagonal = 0, double secondDiagonal = 0, double firstAndThirdHeight = 0, double secondAndFourthHeight = 0, double firstAndThirdAngle = 0, double secondAndFourthAngle = 0)
        {
            _sides = new Side[2] { new Side(firstAndThirdSide), new Side(secondAndFourthSide) };
            _angles = new Angle[2] { new Angle(0, firstAndThirdAngle), new Angle(0, secondAndFourthAngle) };
            _diagonals = new Diagonal[2] { new Diagonal(firstDiagonal), new Diagonal(secondDiagonal) };
            _heights = new Height[2] { new Height(firstAndThirdHeight), new Height(secondAndFourthHeight) };
        }

        public double GetArea()
        {
            if (GetAreaWithHeightFormula() != 0) return GetAreaWithHeightFormula();
            else if (GetAreaWithSinFormula() != 0) return GetAreaWithSinFormula();
            return 0;
        }

        private double GetAreaWithHeightFormula()
        {
            //S = a * h(a)
            if (_sides[0].Length != 0 && _heights[0].Length != 0) return _sides[0].Length * _heights[0].Length;
            else if (_sides[1].Length != 0 && _heights[1].Length != 0) return _sides[1].Length * _heights[1].Length;
            return 0;
        }

        private double GetAreaWithSinFormula()
        {
            //S = a * b * sin(c)
            //if sides not equal 0 and any of angles not equal 0 - solve
            if (_sides.All(s => s.Length != 0)) 
                if(_angles.Any(a => a.Radians != 0))
                    return _sides[0].Length * _sides[1].Length * Math.Sin(_angles.FirstOrDefault(a => a.Radians != 0).Radians);

            return 0;
        }
    }
}