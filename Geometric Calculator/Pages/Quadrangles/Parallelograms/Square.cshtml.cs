using Geometric_Calculator.Models;
using Geometric_Calculator.Models.Quadrangles.Parallelograms;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Quadrangles.Parallelograms
{
    public class SquareModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(string side, string diagonal)
        {
            try
            {
                double[] values = Settings.GetValues(new string[] { side, diagonal });

                Square square = new(values[0], values[1]);

                Message = $"Area = '{square.GetArea()}'";
            }
            catch (Exception exc)
            {
                Message = exc.Message;
            }
        }
    }
}
