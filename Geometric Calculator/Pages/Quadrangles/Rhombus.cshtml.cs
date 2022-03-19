using Geometric_Calculator.Models.Quadrangles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Quadrangles
{
    public class RhombusModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(double side, double diagonalA, double diagonalB, double heightA, double heightB, double angleA, double angleB)
        {
            Rhombus rhombus = new(side, diagonalA, diagonalB, heightA, heightB, angleA, angleB);

            Message = $"Area = '{rhombus.GetArea()}'";
        }
    }
}
