using Geometric_Calculator.Models.Quadrangles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Quadrangles
{
    public class ParallelogramModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(double firstAndThirdSide, double secondAndFourthSide, double firstDiagonal, double secondDiagonal, double firstAndThirdHeight, double secondAndFourthHeight, double firstAndThirdAngle, double secondAndFourthAngle, double angleBetweenDiagonals)
        {
            Parallelogram parallelogram = new(firstAndThirdSide, secondAndFourthSide, firstDiagonal, secondDiagonal, firstAndThirdHeight, secondAndFourthHeight, firstAndThirdAngle, secondAndFourthAngle, angleBetweenDiagonals);

            Message = parallelogram.GetArea().ToString();
        }
    }
}
