using Geometric_Calculator.Models.Quadrangles.Trapezoids;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Quadrangles.Trapezoids
{
    public class TrueTrapezoidModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(double smallWarp, double bigWarp, double side, double angleA, double angleB, double diagonal, double heightA, double heightB)
        {
            TrueTrapezoid trueTrapezoid = new(smallWarp, bigWarp, side, angleA, angleB, diagonal, heightA, heightB);

            Message = $"Area = '{trueTrapezoid.GetArea()}'";
        }
    }
}
