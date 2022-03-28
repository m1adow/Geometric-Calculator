using Geometric_Calculator.Models;
using Geometric_Calculator.Models.Quadrangles.Trapezoids;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Quadrangles.Trapezoids
{
    public class TrapezoidModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(string smallWarp, string bigWarp, string sideA, string sideB, string angleA, string angleB, string angleC, string angleD, string diagonalA, string diagonalB, string heightA, string heightB, string heightC, string heightD)
        {
            try
            {
                double[] values = Settings.GetValues(new string[] { smallWarp, bigWarp, sideA, sideB, angleA, angleB, angleC, angleD, diagonalA, diagonalB, heightA, heightB, heightC, heightD });

                Trapezoid trapezoid = new(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], values[10], values[11], values[12], values[13]);

                Message = $"Area = '{trapezoid.GetArea()}'";
            }
            catch (Exception exc)
            {
                Message = exc.Message;
            }
        }
    }
}