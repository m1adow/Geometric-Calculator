using Geometric_Calculator.Models;
using Geometric_Calculator.Models.Quadrangles.Parallelograms;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Quadrangles.Parallelograms
{
    public class RectangleModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(string sideA, string sideB, string diagonal, string angleBetweenDiagonals)
        {
            try
            {
                double[] values = Settings.GetValues(new string[] { sideA, sideB, diagonal, angleBetweenDiagonals });

                Rectangle rectangle = new(values[0], values[1], values[1], values[3]);

                Message = $"Area = '{rectangle.GetArea()}'";
            }
            catch (Exception exc)
            {
                Message = exc.Message;
            }
        }
    }
}
