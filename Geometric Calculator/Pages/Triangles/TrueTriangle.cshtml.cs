using Geometric_Calculator.Models;
using Geometric_Calculator.Models.Triangles;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Triangles
{
    public class TrueTriangleModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(string side, string heightA, string heightB, string heightC)
        {
            try
            {
                double[] values = Settings.GetValues(new string[] { side, heightA, heightB, heightC });

                TrueTriangle trueTriangle = new(values[0], values[1], values[2], values[3]);

                Message = $"Area = '{trueTriangle.GetArea()}'";
            }
            catch (Exception exc)
            {
                Message = exc.Message;
            }
        }
    }
}
