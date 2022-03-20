using Geometric_Calculator.Models.Quadrangles.Parallelograms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Quadrangles.Parallelograms
{
    public class SquareModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(double side, double diagonal)
        {
            Square square = new(side, diagonal);

            Message = $"Area = '{square.GetArea()}'";
        }
    }
}
