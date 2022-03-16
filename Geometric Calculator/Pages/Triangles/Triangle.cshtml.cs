using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Geometric_Calculator.Models.Triangles;

namespace Geometric_Calculator.Pages
{
    public class TriangleModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(double sideA, double sideB, double sideC, double heightA, double heightB, double heightC, byte angleA, byte angleB, byte angleC)
        {
            Triangle triangle = new(sideA, sideB, sideC, heightA, heightB, heightC, angleA, angleB, angleC);

            Message = $"Area = '{triangle.GetArea()}'";
        }
    }
}
