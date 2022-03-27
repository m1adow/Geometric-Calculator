using Geometric_Calculator.Models;
using Geometric_Calculator.Models.Quadrangles.Parallelograms;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Quadrangles.Parallelograms
{
    public class ParallelogramModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(string sideA, string sideB, string diagonalA, string diagonalB, string heightA, string heightB, string angleA, string angleB, string angleBetweenDiagonals)
        {
            try
            {
                double[] values = Settings.GetValues(new string[] { sideA, sideB, diagonalA, diagonalB, heightA, heightB, angleA, angleB, angleBetweenDiagonals });

                Parallelogram parallelogram = new(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8]);

                Message = $"Area = '{parallelogram.GetArea()}'";
            }
            catch (Exception exc)
            {
                Message = exc.Message;
            }
        }
    }
}
