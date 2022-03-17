using Geometric_Calculator.Models.Quadrangles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Quadrangles
{
    public class ParallelogramModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(double firstAndThirdSide = 0, double secondAndFourthSide = 0, double firstDiagonal = 0, double secondDiagonal = 0, double firstAndThirdHeight = 0, double secondAndFourthHeight = 0, double firstAndThirdAngle = 0, double secondAndFourthAngle = 0)
        {
            Parallelogram parallelogram = new(firstAndThirdSide, secondAndFourthSide, firstDiagonal, secondDiagonal, firstAndThirdHeight, secondAndFourthHeight, firstAndThirdAngle, secondAndFourthAngle);

            Message = parallelogram.GetArea().ToString();
        }
    }
}
