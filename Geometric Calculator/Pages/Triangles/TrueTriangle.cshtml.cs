using Geometric_Calculator.Models.Triangles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Triangles
{
    public class TrueTriangleModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(double side, double heightA, double heightB, double heightC)
        {
            TrueTriangle trueTriangle = new(side, heightA, heightB, heightC);

            Message = $"Area = '{trueTriangle.GetArea()}'";
        }
    }
}
