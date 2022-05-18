using Microsoft.AspNetCore.Mvc.RazorPages;
using Geometric_Calculator.Models.Triangles;
using Geometric_Calculator.Models;

namespace Geometric_Calculator.Pages.Triangles
{
    public class TriangleModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(string sideA, string sideB, string sideC, string heightA, string heightB, string heightC, string angleA, string angleB, string angleC)
        {
            try
            {
                double[] values = Settings.GetValues(new string[] { sideA, sideB, sideC, heightA, heightB, heightC, angleA, angleB, angleC }); //convert input into array

                Triangle triangle = new(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8]); //initiate triangle class

                Message = $"Area = '{triangle.GetArea()}'"; //output value
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
    }
}