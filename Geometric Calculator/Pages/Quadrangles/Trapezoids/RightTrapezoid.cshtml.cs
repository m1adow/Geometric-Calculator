using Geometric_Calculator.Models.Quadrangles.Trapezoids;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Quadrangles.Trapezoids
{
    public class RightTrapezoidModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(double smallWarp, double bigWarp, double sideA, double sideB, double angleC, double angleD, double diagonalA, double diagonalB, double heightA, double heightB, double heightC, double heightD)
        {
            RightTrapezoid rightTrapezoid = new(smallWarp, bigWarp, sideA, sideB, angleC, angleD, diagonalA, diagonalB, heightA, heightB, heightC, heightD);

            Message = $"Area = '{rightTrapezoid.GetArea()}'";
        }
    }
}