using Geometric_Calculator.Models.Triangles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Triangles
{
    public class RightTriangleModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(double sideA, double sideB, double sideC, double heightA, double heightB, double heightC, byte angleA, byte angleB)
        {
            RightTriangle rightTriangle = new(sideA, sideB, sideC, heightA, heightB, heightC, angleA, angleB);

            Message = $"Area = '{rightTriangle.GetArea()}'";
        }
    }
}
