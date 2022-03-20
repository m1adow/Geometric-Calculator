using Geometric_Calculator.Models.Quadrangles.Trapezoids;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Quadrangles.Trapezoids
{
    public class TrapezoidModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(double smallWarp, double bigWarp, double sideA, double sideB, double angleA, double angleB, double angleC, double angleD, double diagonalA, double diagonalB, double heightA, double heightB, double heightC, double heightD)
        {
            Trapezoid trapezoid = new(smallWarp, bigWarp, sideA, sideB, angleA, angleB, angleC, angleD, diagonalA, diagonalB, heightA, heightB, heightC, heightD);

            Message = Message = $"Area = '{trapezoid.GetArea()}'";
        }
    }
}
