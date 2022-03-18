using Geometric_Calculator.Models.Quadrangles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Quadrangles
{
    public class ParallelogramModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(double sideA, double sideB, double diagonalA, double diagonalB, double heightA, double heightB, double angleA, double angleB, double angleBetweenDiagonals)
        {
            Parallelogram parallelogram = new(sideA, sideB, diagonalA, diagonalB, heightA, heightB, angleA, angleB, angleBetweenDiagonals);

            Message = $"Area = '{parallelogram.GetArea()}'";
        }
    }
}
