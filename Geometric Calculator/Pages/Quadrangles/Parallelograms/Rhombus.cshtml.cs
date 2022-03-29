using Geometric_Calculator.Models;
using Geometric_Calculator.Models.Quadrangles.Parallelograms;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Quadrangles.Parallelograms
{
    public class RhombusModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(string side, string diagonalA, string diagonalB, string heightA, string heightB, string angleA, string angleB)
        {
            try
            {
                double[] values = Settings.GetValues(new string[] { side, diagonalA, diagonalB, heightA, heightB, angleA, angleB });

                Rhombus rhombus = new(values[0], values[1], values[2], values[3], values[4], values[5], values[6]);

                Message = $"Area = '{rhombus.GetArea()}'";
            }
            catch (Exception exc)
            {
                Message = exc.Message;
            }
        }
    }
}