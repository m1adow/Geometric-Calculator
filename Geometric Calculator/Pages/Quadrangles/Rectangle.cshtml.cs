using Geometric_Calculator.Models.Quadrangles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Geometric_Calculator.Pages.Quadrangles
{
    public class RectangleModel : PageModel
    {
        public string? Message { get; private set; }

        public void OnPost(double sideA, double sideB, double diagonal, double angleBetweenDiagonals)
        {
            Rectangle rectangle = new(sideA, sideB, diagonal, angleBetweenDiagonals);

            Message=$"Area = '{rectangle.GetArea()}'";
        }
    }
}
